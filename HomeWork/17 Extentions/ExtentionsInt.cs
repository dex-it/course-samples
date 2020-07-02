using System;

namespace _17_Extentions
{
    public static class ExtentionsInt
    {
        public static TimeSpan Hours(this int hours)
        {
            return new TimeSpan(hours, 0, 0);
        }
        public static TimeSpan Minutes(this int minutes)
        {
            int hours = minutes / 60;
            minutes = minutes - (hours * 60);
            return new TimeSpan(hours, minutes, 0);
        }
        public static TimeSpan Seconds(this int seconds)
        {
            int minutes = seconds / 60;
            seconds = seconds - (minutes * 60);
            return minutes.Minutes()+ new TimeSpan(0,0, seconds);
        }
    }
}
