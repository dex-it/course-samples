using System;

namespace Topic_13_Events_dX_
{
	class Program
	{
		static void Main(string[] args)
		{
			var analyst = new Analyst(50);
			analyst.dXEvent += Handler;
			int[] number = new int[] { 10, 8, 9, 8, 11, 20, 5, 13, 12, 1, 7, 9};
			
			for (int i = 0; i < 12; i++)
			{

				Console.WriteLine($"number = {number[i]}");
				analyst.Analysis(number[i]);

			}

			analyst.dXEvent -= Handler;
			
		}
		public static void Handler(string message)
		{
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
