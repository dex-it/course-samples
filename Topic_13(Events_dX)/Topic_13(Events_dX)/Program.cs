using System;

namespace Topic_13_Events_dX_
{
	class Program
	{
		static void Main(string[] args)
		{
			Analyst analyst = new Analyst(50);
			analyst.dXEvent += Handler;
			int[] n = new int[] { 10, 8, 9, 8, 11, 20, 5, 13, 12, 1, 7, 9};
			int number;
			for (int i = 0; i < 12; i++)
			{
				number = n[i];
				Console.WriteLine($"number = {number}");
				analyst.Analysis(number);

			}
			
		}
		public static void Handler(string message)
		{
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
