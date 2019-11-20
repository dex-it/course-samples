using System;

namespace Topic_17RTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();
			car.ColorPropertis = "green";
			car.NumberOfPasagers = 2;
			car.PresentCar();
			Console.WriteLine($"My Speed is = {car.Speed(10, 4)}");
			Console.WriteLine(" _ _ ");

			Car car1 = new Car(4);
			car1.ColorPropertis = "Blue";
			car1.NumberOfPasagers = 7;
			car1.PresentCar();
			Console.WriteLine($"My Speed is = {car1.Speed(58, 2)}");
			Console.Read();
		}
	}
}
