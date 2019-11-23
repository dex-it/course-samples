using System;
using System.Globalization;
using System.Linq;
using Stage1Chapter3;

namespace Stage1Chapter8
{
    public class Program
    {
        static void Main()
        {
            var initRandom = new InitializationRandomAstronomicalObject();
            
            var astro = new AstronomicalObject[99];

            for (int i = 0; i < astro.Length; i++)
            {
                astro[i] = new AstronomicalObject(initRandom.MakeName(), initRandom.MakeWeight(), initRandom.MakeLightEmission());
            }
          
            var astroSelected = astro.Where(a => a.Name.StartsWith("m") && !a.LightEmission).OrderBy(a => a.Radius);
            var sum = astro.Where(a => a.Name.StartsWith("m") && !a.LightEmission).Sum(a => a.Radius);

            long j = 0;
            foreach (var a in astroSelected)
            {
                Console.WriteLine(Convert.ToString(j, CultureInfo.InvariantCulture) + " - " + a.Name + " - " + Convert.ToString(a.LightEmission, CultureInfo.InvariantCulture) + " - " + a.Radius.ToString(CultureInfo.InvariantCulture));
                j++;
            }

            Console.WriteLine("Сумма радиусов планет = " + sum.ToString(CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
