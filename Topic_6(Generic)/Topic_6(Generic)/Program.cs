using System;

namespace Topic_6_Generic_
{
	class Program
	{
		static void Main(string[] args)
		{
			Cars<int> MyCar1 = new Cars<int>();
			MyCar1.Brand = 112;
			MyCar1.NumberOfPasagers = 3;
			MyCar1.PresentTheCar<int, string>(555, "999.9$");

			Console.WriteLine("_ _ _");
			Cars<String> MyCar2 = new Cars<string>();
			MyCar2.Brand = "BMW";
			MyCar2.NumberOfPasagers = 6;
			MyCar2.PresentTheCar<float, double>(1.01f, 473.2);

			Console.WriteLine(MyCar2.HelloMet<int>(5));
			Console.Read();

		}
	}
}
