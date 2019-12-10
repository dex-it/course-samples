using System;
using System.Threading;

namespace Topic_20_ThreadingMutex_
{
	class Program
	{
		static Mutex mutexObj = new Mutex();
		static int x = 0;
		static void Main(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				var myThread = new Thread(Count);
				myThread.Name = $"Поток : {i.ToString()}";
				myThread.Start();
			}

		}

		public static void Count()
		{
			mutexObj.WaitOne();
			x = 1;

			for (int i = 0; i < 9; i++)
			{
				Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
				x++;
				Thread.Sleep(101);
			}

			mutexObj.ReleaseMutex();
		}
	}
}
