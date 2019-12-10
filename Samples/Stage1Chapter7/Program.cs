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
            //Console.WriteLine("Количество звезд Солнечной системы: " + solarSystemEnum.AmountStars);

            AstroEnumerator enumerator = (AstroEnumerator)solarSystemEnum.GetEnumerator();
            AstroEnumerator enumerator2 = (AstroEnumerator)solarSystemEnum.GetEnumerator();
            Console.WriteLine("Объекты Солнечной системы (от Солнца): ");

            while (enumerator.MoveNext())
            {
                var element = (AstronomicalObject)enumerator.Current;
                Console.WriteLine(element.Name);
            }
            enumerator.Reset();

            Console.WriteLine("");

            Console.WriteLine("Объекты Солнечной системы (к Солнцу): ");

            //https://stackoverflow.com/questions/3261153/ienumerator-moving-back-to-record
            while (enumerator2.MovePrev())
            {
                var element = (AstronomicalObject)enumerator2.Current;
                Console.WriteLine(element.Name);
            }
            
            Console.ReadLine();
        }
    }
}
