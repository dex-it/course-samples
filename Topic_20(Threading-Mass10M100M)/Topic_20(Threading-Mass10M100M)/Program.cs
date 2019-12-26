using System.Linq;


namespace Topic_20_Threading_Mass10M100M_
{
	class Program
	{		
		static void Main(string[] args)
		{		
			var mass = Enumerable.Range(1, 100_000_000).ToArray();
			var generationMass = new GenerationMass();
			
			generationMass.SerialCalc(mass);			
			generationMass.ParallelCalc(mass);
						
		}
		
	}
}
