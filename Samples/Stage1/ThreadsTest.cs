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
        public void ConcurrentPrintTest1()
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
        public void ConcurrentFillDictionary()
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

        [Test]
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
    }
}