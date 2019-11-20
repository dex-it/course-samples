using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_4_Downcasting_
{
	class Car : Transport
	{
		public string Brand;
		public Car(string Brand)
		{
			this.Brand = Brand;
		}
		public int NumberOfPassenger { get; set; }
		public void PrezentTheCar()
		{
			Console.WriteLine($"I am {Brand} car, i can carry {NumberOfPassenger} passagers ");
			Console.WriteLine($"I consume {Fuel}");
		}
	}
}
