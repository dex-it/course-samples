using System;

namespace Stage1Chapter7
{
    class StellarSystem
    {
        
        private static void Main(string[] args)
        {
            var solarSystem = new SolarSystem();
            
            foreach (AstronomicalObject a in solarSystem)
            {

                if (a.LightEmission) {
                    Console.WriteLine(a.Name + " - это звезда." );
                }
                else
                {
                    Console.WriteLine(a.Name + " - это планета.");
                }
                    
            }

            Console.ReadLine();
        }
    }
}
