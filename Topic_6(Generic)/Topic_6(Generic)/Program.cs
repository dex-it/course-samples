using System;

namespace Topic_6_Generic_
{
	class Program
	{
		static void Main(string[] args)
		{
			var myCar1 = new Car<int>();
			myCar1.Brand = 112;
			myCar1.NumberOfPasagers = 3;
			myCar1.PresentTheCar<int, string>(555, "999.9$");

			Console.WriteLine("_ _ _");
			var myCar2 = new Car<string>();
			myCar2.Brand = "BMW";
			myCar2.NumberOfPasagers = 6;
			myCar2.PresentTheCar<float, double>(1.01f, 473.2);

		}
	}
}
