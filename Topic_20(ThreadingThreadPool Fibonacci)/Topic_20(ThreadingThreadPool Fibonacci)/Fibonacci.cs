using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Topic_20_ThreadingThreadPool_Fibonacci_
{
	public class Fibonacci
	{
		private ManualResetEvent _doneEvent;

		public Fibonacci(int n, ManualResetEvent doneEvent)
		{
			N = n;
			_doneEvent = doneEvent;
		}

		public int N { get; }
		public int FibOfN{ get; private set; }

		public void ThreadPoolCallback(Object threadContext)
		{
			int threadIndex = (int)threadContext;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Thread {threadIndex} satarted...");
			FibOfN = Calculate(N);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Thread {threadIndex} result calculated...");
			Console.ForegroundColor = ConsoleColor.White;
			_doneEvent.Set();
		}

		public int Calculate(int n)
		{
			if (n<=1)
			{
				return n;
			}
			return Calculate(n - 1) + Calculate(n-2);
		}
	}
}
