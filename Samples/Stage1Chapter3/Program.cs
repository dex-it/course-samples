using System;
using System.Globalization;

namespace Stage1Chapter3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            
            //Создание Солнечной системы
            var solarSystem = new SolarSystem();


            Console.WriteLine("Количество планет Солнечной системы: " + solarSystem.AmountPlanets.ToString());
            Console.WriteLine("Планеты Солнечной системы: ");
            foreach (var p in solarSystem.GetListPlanets())
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("Количество карликовых планет Солнечной системы: " + solarSystem.AmountDwarfPlanets.ToString());
            Console.WriteLine("Карликовые планеты Солнечной системы: ");
            foreach (var dp in solarSystem.GetListDwarfPlanets())
            {
                Console.WriteLine(dp.Name);
            }

            Console.WriteLine("Площадь поверхности Плутона (км2):");
            foreach (var dp in solarSystem.GetListDwarfPlanets())
            {
                if (dp.Name != "Pluto") continue;
                Console.WriteLine(dp.GetSurfaceArea().ToString(CultureInfo.InvariantCulture));
                break;

            }

            Console.WriteLine("Площадь поверхности Солнца (км2):");
            foreach (var s in solarSystem.GetListStars())
            {
                if (s.Name != "Sun") continue;
                Console.WriteLine(s.GetSurfaceArea().ToString(CultureInfo.InvariantCulture));
                break;

            }

            Console.ReadLine();
        }
    }
}
