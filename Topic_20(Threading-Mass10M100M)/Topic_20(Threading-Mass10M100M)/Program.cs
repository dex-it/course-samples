﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_20_Threading_Mass10M100M_
{
	class Program
	{
		
		static void Main(string[] args)
		{
			int[] mass10M = new int[10000000];
			int[] mass100M = new int[100000000];
			int[] testmss = new int[100];
			GenerationMass generationmass = new GenerationMass();	
			
			generationmass.SerialCalc(testmss);
			generationmass.ParallelCalc(testmss);
			generationmass.CalcEvent += CalcHandler;
			generationmass.ParalelCalc2(testmss);
		}

		public static void CalcHandler(int i, int[] mass)
		{
			int a = 0;
			long sum = 0;
			double medium = 0;

			while (a < i)
			{
				sum = sum + mass[a];
				medium = ((double)sum / mass.Length);
				a++;
			}
			//Console.WriteLine($"medium = {medium}");
		}
	}
}