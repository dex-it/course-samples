using System;
using Stage1Chapter3;

namespace Stage1Chapter4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var earth = new Planet("Earth", 6371);

            var moon = new SatelliteCloneable("Moon", 1737)
            {
                ParentPlanet = earth
            };

            //Поверхностное клонирование
            var moonClone = (SatelliteCloneable)moon.Clone();
            //Глубокое клонирование
            //var moonClone = (SatelliteCloneable)moon.DeepClone();

            moon.Name = "Titan";
            moon.ParentPlanet.Name = "Saturn";

            Console.WriteLine(moonClone.Name + " - " + moonClone.ParentPlanet.Name);
            //Clone
            //Moon - Saturn 
            //Результат поверхностного копирования, когда ссылочные свойства все еще указывают на участки памяти, клонируемого объекта.

            //DeepClone
            //Moon - Earth
            //Результат глубокого копирования.

            Console.ReadLine();


        }
    }
}
