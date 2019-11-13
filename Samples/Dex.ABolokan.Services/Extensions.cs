using System;
using System.Collections.Generic;
using System.Text;

namespace Dex.ABolokan.Services
{
	public static class TimeExtensions
	{
		public static double Seconds(this TimeSpan timeSpan)
		{
			return timeSpan.TotalSeconds;
		}

		public static TimeSpan GetTimeSpan(this double seconds)
		{
			return TimeSpan.FromSeconds(seconds);
		}
	}
}
