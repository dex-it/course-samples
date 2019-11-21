using System;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Stage1.MyThreadsTest
{
    public class MyJobExecutorTest
    {
        [Test]
        public void JobExecutorTest()
        {
            var jobExecutor = new MyJobExecutor();

            for (int i = 0; i < 10; i++)
            {
                jobExecutor.Add(() => { Console.WriteLine(Task.CurrentId); });
            }

            Assert.AreEqual(jobExecutor.Amount, 10);
            jobExecutor.Start(10);
            Assert.AreEqual(jobExecutor.Amount, 0);
        }
    }
}