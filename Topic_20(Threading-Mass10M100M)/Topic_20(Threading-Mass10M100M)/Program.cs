using System;
using System.Linq;


namespace Topic_20_Threading_Mass10M100M_
{
	class Program
	{		
		static void Main(string[] args)
		{
			var mass = Enumerable.Range(1, 100_000_000).ToArray();
			var test = new Test();
			var part =  1_000_000;

			test.SerialCalc(mass);
			test.ParallelCalc(mass, part);
			
			Console.WriteLine("________Прогрев________");

			test.SerialCalc(mass);
			test.ParallelCalc(mass, part);
		}
		
	}
}
