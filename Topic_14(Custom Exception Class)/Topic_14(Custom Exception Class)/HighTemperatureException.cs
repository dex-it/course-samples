using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_14_Custom_Exception_Class_
{
	class HighTemperatureException:AggregateException
	{
		public double Value { get; set; }
		public HighTemperatureException(string message, double val):base(message)
		{
			Value = val;
		}
	}
}
