using System;
using System.Threading;

namespace Topic_20_ThreadingThreadPool_Fibonacci_
{
	class Program
	{
		static void Main(string[] args)
		{
			const int FibonacciCalculations = 7;
			var doneEvents = new ManualResetEvent[FibonacciCalculations];
			var fibArray = new Fibonacci[FibonacciCalculations];
			var rand = new Random();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"Launching {FibonacciCalculations} task....");
			for (int i = 0; i < FibonacciCalculations; i++)
			{
				doneEvents[i] = new ManualResetEvent(false);
				var f = new Fibonacci(rand.Next(20, 40), doneEvents[i]);
				fibArray[i] = f;
				ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, i);
			}

			WaitHandle.WaitAll(doneEvents);
			Console.WriteLine("Все вычисления завершены");
			for (int i = 0; i < FibonacciCalculations; i++)
			{
				Fibonacci f = fibArray[i];
				Console.WriteLine($"Fibonacci ({f.N}) = {f.FibOfN}");
			}
		}
	}
}
