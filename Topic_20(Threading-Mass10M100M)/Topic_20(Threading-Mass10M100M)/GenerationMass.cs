using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_20_Threading_Mass10M100M_
{
	public class GenerationMass
	{
		public void SerialCalc(int[] mass)
		{
			var time = new Stopwatch();

			time.Start();

			var medium = LocalMedium(mass.Length, 0, mass);

			time.Stop();
			Console.WriteLine("The sequential study is complete.");
			Console.WriteLine($"max = {mass.Last()}, final medium = {medium}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");
		}


		public void ParallelCalc(int[] mass)
		{
			long SumOfMediums = 0;
			var part = 1_000_000;
			var countOfPart = mass.Length / part;

			var time = new Stopwatch();

			time.Start();

			Parallel.For(0, countOfPart, index =>
			{
				Interlocked.Add(ref SumOfMediums, LocalMedium(part, index, mass));
			});

			time.Stop();

			Console.WriteLine("\nThe parallel study is complete.");
			Console.WriteLine($"max = {mass.Last()} final medium = {SumOfMediums / countOfPart}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");

		}
		private long LocalMedium(int part, int i, int[] mass)
		{
			var sum = 0;
			var min = i * part;
			var max = (i * part) + part;

			for (int j = min; j < max; j++)
			{
				sum += mass[j];
			}

			return sum / part;
		}
	}
}
