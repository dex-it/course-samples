using System;
using System.Threading;

namespace Topic_20_ThreadingThreadPool_
{
	class Program
	{
		static int inc = 0;
		static void Main(string[] args)
		{
			int nWorkerThreads;
			int nCompletionThreads;

			ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionThreads);
			Console.WriteLine("Максимальное количество потоков: " + nWorkerThreads +"\n Потоков ввода -вывода  доступно: " + nCompletionThreads);

			for (int i = 0; i < 5; i++)
			{
				inc++;
				ThreadPool.QueueUserWorkItem(JobForAThread);
				Thread.Sleep(500);
				Console.WriteLine($"_ _ inc = {inc} _ _");
				
			}
		}

		static void JobForAThread(object state)
		{
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("цикл {0}, выполнение внутри потока из пула {1}", i, Thread.CurrentThread.ManagedThreadId);
				Thread.Sleep(1000);
			}
		}
	}
}
