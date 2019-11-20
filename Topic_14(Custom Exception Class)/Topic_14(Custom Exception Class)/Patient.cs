using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_14_Custom_Exception_Class_
{
	class Patient
	{
		public string Name { get; set; }
		public int Age{get; set;}
		private double temperature;
		public double Temperature
		{
			get { return temperature; }
			set
			{
				if (value>36.6)
				{
					throw new HighTemperatureException("Внимание у пацента повышная температура, примите меры!", value);
				}
				else
				{
					temperature = value;
				}
			}
		}
	}
}
