using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Topic_20_Threading_Mass10M100M_
{
	class Program
	{		
		static void Main(string[] args)
		{
			
			int[] mass100M = new int[100_000_000];

			for (int i = 0; i < mass100M.Length; i++)
			{
				mass100M[i] = i;
			}

			var generationmass = new GenerationMass();
			
			generationmass.SerialCalc(mass100M);			
			generationmass.ParallelCalc(mass100M);
						
		}
		
	}
}
