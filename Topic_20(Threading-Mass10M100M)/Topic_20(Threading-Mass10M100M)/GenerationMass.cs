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
		public delegate void CalcDelegate(int i, int[] mass);
		public event CalcDelegate CalcEvent;

		private int[] mass1 = new int[1000];// для работы с Parallel.For

		public void SerialCalc(int[] mass)
		{
			double medium = 0;
			long sum = 0;
			int a = 0;
			var time = new Stopwatch();

			time.Start();

			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = i;

				while (a < i)
				{
					sum = sum + mass[a];
					medium = ((double)sum / mass.Length);
					a++;
				}

				//Console.WriteLine($"mass10M[i] = {mass[i]} medium = {medium}");
			}
			time.Stop();
			Console.WriteLine("Последовательное исследование завершено.");
			Console.WriteLine($"max = {mass[mass.Length - 1]}, final medium = {medium}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");
		}


		public void ParallelCalc(int[] mass)
		{
			object locker = new object();
			long grandTotal = 0;
			double medium = 0;
			int k = 1000000;

			var time = new Stopwatch();

			time.Start();

			Parallel.For<long>(0, mass.Length/k, () => 0, (i, state, subtotal) =>
			{
				for (int j = i*k; j < ((i*k)+k); j++)
				{
					subtotal += mass[i];
					medium = (double)subtotal / mass.Length;					
				}
				
				return subtotal;
			},
				(x) => Interlocked.Add(ref grandTotal, x)
			);

			time.Stop();

			Console.WriteLine("\nПаралельное исследование завершено.");
			Console.WriteLine($"max = {mass[mass.Length - 1]}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");

		}	
	}
}
