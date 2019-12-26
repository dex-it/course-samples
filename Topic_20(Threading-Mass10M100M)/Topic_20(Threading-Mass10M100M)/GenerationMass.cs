using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_20_Threading_Mass10M100M_
{
	public class GenerationMass
	{
		public void SerialCalc(int[] mass)
		{
			long medium;			
			var time = new Stopwatch();

			time.Start();			

			medium = LocalMedium(mass.Length, 0, mass);
			
			time.Stop();
			Console.WriteLine("The sequential study is complete.");
			Console.WriteLine($"max = {mass[mass.Length - 1]}, final medium = {medium}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");
		}


		public void ParallelCalc(int[] mass)
		{			
			long mediumSum = 0;
			int part = 1_000_000;
			int countOfPart = mass.Length / part;		

			var time = new Stopwatch();

			time.Start();
			
			Parallel.For(0, countOfPart, index => 
			{
				Interlocked.Add(ref mediumSum, LocalMedium(part, index, mass));
			});

			time.Stop();

			Console.WriteLine("\nThe parallel study is complete.");
			Console.WriteLine($"max = {mass[mass.Length - 1]} final medium = {mediumSum/countOfPart}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");

		}
		private long LocalMedium(int part, int i, int[] mass)
		{
			long medium;
			long sum = 0;

			for (int j = i * part; j < ((i * part) + part); j++)
			{
				sum += mass[j];				
			}

			medium = sum / part;			
			return medium;
		}
	} 
}
