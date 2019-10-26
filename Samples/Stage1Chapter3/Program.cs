using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Создание Солнечной системы
            SolarSystem solarSystem = new SolarSystem();


            Console.WriteLine("Количество планет Солнечной системы: " + solarSystem.AmountPlanets.ToString());
            Console.WriteLine("Планеты Солнечной системы: ");
            foreach (Planet p in solarSystem.GetListPlanets())
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("Количество карликовых планет Солнечной системы: " + solarSystem.AmountDwarfPlanets.ToString());
            Console.WriteLine("Карликовые планеты Солнечной системы: ");
            foreach (DwarfPlanet dp in solarSystem.GetListDwarfPlanets())
            {
                Console.WriteLine(dp.Name);
            }

            Console.WriteLine("Площадь поверхности Плутона (км2):");
            foreach (DwarfPlanet dp in solarSystem.GetListDwarfPlanets())
            {
                if (dp.Name == "Pluto")
                {
                    Console.WriteLine(dp.SurfaceArea().ToString());
                    break;
                }
                      
            }

            Console.WriteLine("Площадь поверхности Солнца (км2):");
            foreach (Star s in solarSystem.GetListStars())
            {
                if (s.Name == "Sun")
                {
                    Console.WriteLine(s.SurfaceArea().ToString());
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}
