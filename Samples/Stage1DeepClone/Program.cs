using System;
using Stage1Chapter3;

namespace Stage1DeepClone
{
    class Program
    {
        static void Main(string[] args)
        {
            var earth = new Planet("Earth", 6371);
            
            var moon = new Satellite("Moon", 1737)
            {
                ParentPlanet = earth
            };
            
            Cloneable cloneObject = new Cloneable();
            var moonNew = (Satellite)cloneObject.DeepCopy(moon);

            Console.WriteLine($"ParentPlanet.Name: {moonNew.ParentPlanet.Name}");

            Console.ReadLine();

        }
    }
}
