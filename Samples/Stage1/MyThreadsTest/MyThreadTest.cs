using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Stage1.MyThreadsTest
{
    public class MyThreadTest : IJobExecutor
    {
        private List<Action> Actions { get; set; } = new List<Action>();

        private bool ProcessingCanceled = false;

        public int Amount => Actions.Count;

        public void Start(int maxConcurrent)
        {
            if (maxConcurrent <= 0) throw new ArgumentOutOfRangeException(nameof(maxConcurrent));

            ThreadPool.SetMaxThreads(maxConcurrent, maxConcurrent);

            foreach (var action in Actions)
            {
                if (ProcessingCanceled)
                {
                    return;
                }

                ThreadPool.QueueUserWorkItem(state =>
                {
                    action.Invoke();
                });
            }
        }

        public void Stop()
        {
            ProcessingCanceled = true;
        }

        public void Add(Action action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            Actions.Add(action);
        }

        public void Clear()
        {
            Actions.Clear();
        }

    }


    public class Test
    {
        [Test]
        public void ThreadsTest()
        {
            var threadTest = new MyThreadTest();

            for (int i = 0; i < 100; i++)
            {
                threadTest.Add(new Action(() =>
                {
                    Console.WriteLine(Task.CurrentId + "  ThreadId " + Thread.CurrentThread.ManagedThreadId);

                }));
            }
            Console.WriteLine(threadTest?.Amount);

            threadTest.Start(10);

        }
    }
}