using System;
using Stage1Chapter3;

namespace Stage1Chapter7
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
            var solarSystemEnum = new SolarSystemEnum();
            
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
            
            Console.WriteLine("Количество звезд Солнечной системы: " + solarSystemEnum.AmountStars);
            Console.WriteLine("Звезды Солнечной системы: ");
            foreach (var st in solarSystemEnum.GetListStars())
            {
                Console.WriteLine(st.Name);
            }
            Console.ReadLine();
        }
    }
}
