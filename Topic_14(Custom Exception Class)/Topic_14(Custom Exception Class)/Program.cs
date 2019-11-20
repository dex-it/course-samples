using System;

namespace Topic_14_Custom_Exception_Class_
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Patient patient1 = new Patient
				{
					Name = "Семён",
					Age = 34,
					Temperature = 40.0
				};
				Console.WriteLine("Patient wos created");
			}
			catch (HighTemperatureException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine($"Текущая температура = {ex.Value} *C");
			}
		}
	}
}
