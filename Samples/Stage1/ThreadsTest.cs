using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ThreadsTest
    {
        [Test]
        public void ConcurrentPrintTest()
        {
            var timeout = 1000;
            var isRun = true;
            var countdown = new CountdownEvent(2);

            ThreadPool.QueueUserWorkItem(state =>
            {
                Write("x", isRunning: ref isRun);
                countdown.Signal();
            });
            ThreadPool.QueueUserWorkItem(state =>
            {
                Write("y", isRunning: ref isRun);
                countdown.Signal();
            });

            Thread.Sleep(timeout);

            isRun = false;

            // ждем завершения
            countdown.Wait();
        }

        private void Write(string letter, ref bool isRunning)
        {
            while (isRunning)
            {
                Console.Write(letter);
                Thread.Sleep(200);
            }
        }

        [Test]
        public void ConcurrentFillDictionaryTest()
        {
            var dict = new Dictionary<string, string>();
            var locker = new object();
            var count = 10;
            var completed = 0;

            ThreadPool.QueueUserWorkItem(_ => // запуск параллельного потока
            {
                var c = count; // захват значения
                while (c-- > 0)
                {
                    lock (locker) // синхронизация
                    {
                        dict.Add("1_" + c, "hello thread1");
                    }
                }

                Interlocked.Increment(ref completed); // потокобезопасный инкремент числа
            });

            ThreadPool.QueueUserWorkItem(_ => // запуск параллельного потока
            {
                var c = count; // захват значения
                while (c-- > 0)
                {
                    lock (locker) // синхронизация
                    {
                        dict.Add("2_" + c, "hello thread2");
                    }
                }

                Interlocked.Increment(ref completed); // потокобезопасный инкремент числа
            });

            while (completed < 2) // ожидание завершения, countdownEvent лучше подходит для такого случая, приведено для примера
            {
                Thread.Sleep(25);
            }

            foreach (var x in dict)
            {
                Console.WriteLine(x.Key + " : " + x.Value);
            }
        }

//        [Test]
        [Timeout(2000)]
        public void DeadlockTest()
        {
            var locker1 = new object();
            var locker2 = new object();

            // thread 1
            ThreadPool.QueueUserWorkItem(_ =>
            {
                lock (locker1) // блокировка 1
                {
                    Thread.Sleep(1000);
                    lock (locker2) // блокировка 2
                    {
                        Console.WriteLine("Thread 1 got both locks");
                    }
                }
            });

            // thread 2
            lock (locker2) // блокировка 2
            {
                Thread.Sleep(1000);
                lock (locker1) // блокировка 1
                {
                    Console.WriteLine("Thread 2 got both locks");
                }
            }
        }

        [Test]
        [Timeout(5000)]
        public void ConcurrentMutableStructTest()
        {
            LargeStruct mutable = new LargeStruct();

            ThreadPool.QueueUserWorkItem(delegate
            {
                decimal n = 0;
                while (true)
                {
                    var newStruct = new LargeStruct
                    {
                        D1 = n,
                        D2 = n,
                        D3 = n,
                        D4 = n,
                        D5 = n,
                    };
                    mutable = newStruct;
                    n++;
                }
            });

            Assert.Throws<AssertionException>(() =>
            {
                while (true)
                {
                    Validate(mutable);
                }
            });
        }

        private static void Validate(LargeStruct largeStruct)
        {
            decimal n = largeStruct.D1;
            Assert.IsTrue(n == largeStruct.D2);
            Assert.IsTrue(n == largeStruct.D3);
            Assert.IsTrue(n == largeStruct.D4);
            Assert.IsTrue(n == largeStruct.D5);
        }

        private struct LargeStruct
        {
            public decimal D1;
            public decimal D2;
            public decimal D3;
            public decimal D4;
            public decimal D5;
        }
    }
}