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

		private int[] mass = new int[100000];

		public  void SerialCalc(int[] mass)
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
			Console.WriteLine($"max = {mass[mass.Length - 1]}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");
		}

		public void ParallelCalc1(int[] mass)
		{
			int a = 0;
			long sum = 0;
			double medium = 0;
			var time = new Stopwatch();
			time.Start();				

			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = i;
				
				Task task = Task.Factory.StartNew(() =>
				{

					while (a < i)
					{
						sum = sum + mass[a];
						medium = ((double)sum / mass.Length);
						a++;
					}
					
					//Console.WriteLine($"i = {i} medium = {medium}");
					
				});

				if (i == mass.Length)
				{
					task.Wait();
				}
				
			}			
			
			time.Stop();
			Console.WriteLine("Паралельное исследование №1 завершено.");
			Console.WriteLine($"max = {mass[mass.Length - 1]}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");
		}

		public void ParallelCalc2(int[] mass)
		{
			
			var time = new Stopwatch();
			time.Start();

			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = i;
				CalcEvent?.Invoke(i,mass);
			}

			time.Stop();
			Console.WriteLine("Паралельное исследование №2 завершено.");
			Console.WriteLine($"max = {mass[mass.Length - 1]}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");
		}

		public void ParallelCalc3()
		{
			var time = new Stopwatch();
			time.Start();

			Parallel.For(1, mass.Length, CalcMedium);

			time.Stop();
			Console.WriteLine("Паралельное исследование №3 завершено.");
			Console.WriteLine($"max = {mass[mass.Length - 1]}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");

		}

		private void CalcMedium(int i)
		{
			int a = 0;
			long sum = 0;
			double medium = 0;
			
			mass[i] = i;

			while (a < mass.Length)
			{
				sum = sum + mass[a];
				medium = ((double)sum / mass.Length);
				a++;
			}
			a = 0;
			//Console.WriteLine($"medium = {medium}");
		}
		
	}
}
