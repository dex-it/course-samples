using System;
using Stage1Chapter14;


namespace Stage1Chapter17
{
    class Program
    {
        static void Main(string[] args)
        {
            AstronomicalObject astro = new AstronomicalObject("Earth", 6371, false);
            Console.WriteLine("Radius of {0} = {1} km", astro.Name, astro.Radius);
            Console.WriteLine("Volume of {0} = {1} km3", astro.Name, astro.GetVolume());
            Console.ReadLine();
        }
    }
}
