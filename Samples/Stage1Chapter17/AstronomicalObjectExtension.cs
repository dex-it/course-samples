using System;
using Stage1Chapter14;


namespace Stage1Chapter17
{
    public static class AstronomicalObjectExtension
    {
        public static double GetVolume(this AstronomicalObject astro)
        {
            return Math.Round(4/3 * (double)astro.Radius * Math.PI, 0);
        }
    }
}
