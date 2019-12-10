using System;
using System.Diagnostics;

namespace Topic_5_boxing_and_unboxing_Time_
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int a = 123;
			int b;
			object Sempl1;
			var time1 = new Stopwatch();
			var time2 = new Stopwatch();

			Console.WriteLine("_ _ _ boxing _ _ _");
			time1.Start();			
			Sempl1 = a;			
			time1.Stop();		
			Console.WriteLine($"processDuration = {time1.Elapsed}");

			Console.WriteLine("_ _ _ unboxing _ _ _");
			time2.Start();
			b = (int)Sempl1;
			time2.Stop();
			Console.WriteLine($"processDuration = {time2.Elapsed}");

		}
	}
}
