using System;
using Stage1Chapter10;

namespace Stage1Chapter11
{
    class Program
    {
        static void Main()
        {
            PlanetBook book = new PlanetBook();

            var mercury = new AstronomicalObjectEqual("Mercury", 2439, false);
            var venus = new AstronomicalObjectEqual("Venus", 6051, false);
            var earth = new AstronomicalObjectEqual("Earth", 6371, false);
            var mars = new AstronomicalObjectEqual("Mars", 3389, false);
            var jupiter = new AstronomicalObjectEqual("Jupiter", 69911, false);
            var saturn = new AstronomicalObjectEqual("Saturn", 58232, false);
            var uranus = new AstronomicalObjectEqual("Uranus", 25362, false);
            var neptune = new AstronomicalObjectEqual("Neptune", 24622, false);

            book.AddAstronomicalObject(mercury, 1);
            book.AddAstronomicalObject(venus, 2);
            book.AddAstronomicalObject(earth, 3);
            book.AddAstronomicalObject(mars, 4);
            book.AddAstronomicalObject(jupiter, 5);
            book.AddAstronomicalObject(saturn, 6);
            book.AddAstronomicalObject(uranus, 7);
            book.AddAstronomicalObject(neptune, 8);
            //book.AddAstronomicalObject(earth, 9);

            Console.WriteLine("Number from Sun (Earth): " + book.GetNumberFromSun(earth));
            Console.ReadLine();


        }
    }
}
