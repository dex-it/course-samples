using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_4_Downcasting_
{
	class Transport
	{
		public int NumberOfWheels{get;set;}
		public static string Fuel = "gasoline";

		public void Present()
		{
			Console.WriteLine("I am a transpotr");
		}
		
	}
}
