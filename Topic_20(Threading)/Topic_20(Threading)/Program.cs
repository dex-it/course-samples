using System;
using System.Threading;

namespace Topic_20_Threading_
{
	class Program
	{
		static void Main(string[] args)
		{
			var counter = new Counter(4,5);			

			var myThread = new Thread(new ThreadStart(counter.Count));
			myThread.Start();

			for (int i = 1; i < 9; i++)
			{
				Console.WriteLine("Главный поток:");
				Console.WriteLine(i*i);
				Thread.Sleep(300);
			}
		}

		
	}
}
