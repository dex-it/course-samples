using System;
using System.Collections;
using Stage1Chapter3;

namespace Stage1Chapter7
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
            var solarSystemEnum = new SolarSystemEnum();
            
            // 1
            foreach (AstronomicalObject a in solarSystemEnum)
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

            // 2
            AstroEnumerator enumerator = (AstroEnumerator)solarSystemEnum.GetEnumerator();
            Console.WriteLine("Объекты Солнечной системы (от Солнца): ");
            
            while (enumerator.MoveNext())
            {
                var element = (AstronomicalObject)enumerator.Current;
                Console.WriteLine(element.Name);
            }

            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
