using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_6_Generic_
{
	class Car <T>
	{
		public T Brand;
		public T NumberOfWheel { get; set; }
		public int NumberOfPasagers { get; set; }

		public void PresentTheCar<N, P>(N CarNumber, P CarPrice)
		{
			Console.WriteLine($"The car braend is : {Brand},");
			Console.WriteLine($"the number of the car is : {CarNumber},");
			Console.WriteLine($"the car cost = {CarPrice},");
			Console.WriteLine($"the car can accommodate {NumberOfPasagers} passengers.");
		}		
	}
}
