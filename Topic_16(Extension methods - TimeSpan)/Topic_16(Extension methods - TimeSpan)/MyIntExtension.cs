using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_16_Extension_methods___TimeSpan_
{
	public static class MyIntExtension
	{
		public static TimeSpan Seconds(this int interval)
		{
			var timeSpan = new TimeSpan(0, 0, interval);
			
			return (timeSpan);
		}
		public static TimeSpan Minutes(this int interval)
		{
			var timeSpan = new TimeSpan(0, interval, 0);

			return (timeSpan);
		}

		public static TimeSpan Hours(this int interval)
		{
			var timeSpan = new TimeSpan(interval, 0, 0);

			return (timeSpan);
		}

	}
}
