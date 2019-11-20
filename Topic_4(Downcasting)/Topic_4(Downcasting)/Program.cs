using System;

namespace Topic_4_Downcasting_
{
	class Program
	{
		static void Main(string[] args)
		{
			Transport transport = new Transport();
			transport.NumberOfWheels = 3;
			transport.Present();
			//Transport.Fuel = "H2";

			Bike bike = new Bike("Suzuki");
			bike.PrezentTheBike();

			Car car = new Car("BMW");
			car.NumberOfPassenger = 4;
			car.PrezentTheCar();


			Console.WriteLine("_ _ _ as _ _ _");

			car = transport as Car;
			if (car == null)
			{
				Console.WriteLine("Преобразование не удалось");
			}
			else
			{
				car.PrezentTheCar();
			}


			Console.WriteLine("_ _ _  InvalidCastException _ _ _");

			try
			{
				bike = (Bike)transport;
			}
			catch (InvalidCastException ex)
			{
				Console.WriteLine(ex.Message);
			}


			Console.WriteLine("_ _ _ is _ _ _");

			if (transport is Car)
			{
				car = (Car)transport;
			}
			else
			{
				Console.WriteLine("Преобразование не допустимо");
			}
		}
	}
}
