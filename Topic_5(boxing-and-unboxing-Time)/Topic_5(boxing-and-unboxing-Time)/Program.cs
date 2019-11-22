using System;

namespace Topic_5_boxing_and_unboxing_Time_
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int a = 123;
			int b;
			object Sempl1;
			long t1;
			long t2;			
			TimeSpan processDuration;


			Console.WriteLine("_ _ _ boxing _ _ _");
			t1 = DateTime.Now.Ticks;
			Sempl1 = a;
			t2 = DateTime.Now.Ticks;			
			processDuration = new TimeSpan(t2 - t1);
			Console.WriteLine($"processDuration = {processDuration.Ticks} ticks    t1 = {t1} t2 = {t2}");

			Console.WriteLine("_ _ _ unboxing _ _ _");			
			t1 = DateTime.Now.Ticks;
			b = (int)Sempl1;
			t2 = DateTime.Now.Ticks;
			processDuration = new TimeSpan(t2 - t1);
			Console.WriteLine($"processDuration = {processDuration.Ticks} ticks    t1 = {t1} t2 = {t2}");

		}
	}
}
