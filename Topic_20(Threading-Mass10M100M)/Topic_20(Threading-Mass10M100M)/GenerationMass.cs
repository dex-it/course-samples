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

			Task task = Task.Factory.StartNew(() =>
			{
				for (int i = 0; i < mass.Length; i++)
				{
					mass[i] = i;
					CalcEvent?.Invoke(i, mass);
					//Console.WriteLine($"i = {i}");
				}
			});

			task.Wait();

			time.Stop();
			Console.WriteLine("Паралельное исследование №2 завершено.");
			Console.WriteLine($"max = {mass[mass.Length - 1]}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");
		}

		public void ParallelCalc3()
		{
			var time = new Stopwatch();
			time.Start();

			Parallel.For(1, mass1.Length, CalcMedium);

			time.Stop();
			Console.WriteLine("Паралельное исследование №3 завершено.");
			Console.WriteLine($"max = {mass1[mass1.Length - 1]}");
			Console.WriteLine($" _ _ time = {time.Elapsed} _ _ ");

		}

		private void CalcMedium(int i)
		{
			int a = 0;
			long sum = 0;
			double medium = 0;

			mass1[i] = i;

			while (a < mass1.Length)
			{
				sum = sum + mass1[a];
				medium = ((double)sum / mass1.Length);
				a++;
			}

			a = 0;
			//Console.WriteLine($"medium = {medium}");
		}

	}
}
