using System;
using System.Threading;

namespace Topic_20_ThreadingMonitor_
{
	class Program
	{
		static int x = 0;
		static object locker = new object();
		static void Main(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				Thread myThread = new Thread(Count);
				myThread.Name = $"Поток {i.ToString()}";
				myThread.Start();
			}
			
		}
		public static void Count()
		{
			bool acquiredLock = false;

			try
			{
				Monitor.Enter(locker, ref acquiredLock);
				x = 1;
				for (int i = 0; i < 9; i++)
				{
					Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
					x++;
					Thread.Sleep(100);
				}
			}
			finally
			{
				if (acquiredLock)
				{
					Monitor.Exit(locker);
				}
			}
		}
	}
}
