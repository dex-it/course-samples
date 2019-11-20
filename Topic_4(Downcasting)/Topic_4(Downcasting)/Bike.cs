using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_4_Downcasting_
{
	class Bike : Transport
	{
		
		public string Brand { get; set; }

		public Bike(string Brand)
		{
			this.Brand = Brand;
		}
		public void PrezentTheBike()
		{
			Console.WriteLine($"I am {Brand} bike ");
			Console.WriteLine($"I consume {Fuel}");
		}
	}
}
