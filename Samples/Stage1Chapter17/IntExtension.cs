using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter17
{
    public static class IntExtension
    {
        public static TimeSpan Seconds(this int intToSeconds)
        {
            return new TimeSpan(0, 0, intToSeconds);
        }

    }
}
