using System;
using System.Threading;

namespace Topic_20_ThreadingTimer_
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = 0;
			var tm = new TimerCallback(Count);
			var timer = new Timer(tm, num, 0, 2000);
			Console.ReadKey();
		}

		public static void Count(object obj)
		{
			int x = (int)obj;

			for (int i = 0; i < 9; i++, x++)
			{
				Console.WriteLine($"{x*i}");
				Thread.Sleep(100);
			}
		}

	}
}
