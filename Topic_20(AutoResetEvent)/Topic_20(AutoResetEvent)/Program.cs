using System;
using System.Threading;

namespace Topic_20_AutoResetEvent_
{
	class Program
	{
		static AutoResetEvent waitHandler = new AutoResetEvent(true);
		static int x = 0;
		static void Main(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				Thread myThread = new Thread(Count);

				myThread.Name = $"Поток : {i.ToString()}";
				myThread.Start();
			}

		}

		public static void Count()
		{
			waitHandler.WaitOne();
			x = 1;

			for (int i = 0; i < 9; i++)
			{
				Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
				x++;
				Thread.Sleep(101);
			}

			waitHandler.Set();
		}
	}
}
