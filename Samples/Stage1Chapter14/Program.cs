using System;
using System.ComponentModel;
using Stage1Chapter10;
using Stage1Chapter11;

namespace Stage1Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1
            AstronomicalObject astro = new AstronomicalObject();
            
            PropertyChangedEventHandler onPropertyChanged = delegate {
                Console.WriteLine("Changed properties: ");
                Console.WriteLine("Name: " + astro.Name + ", Radius: " + astro.Radius + ", LightEmission: " + astro.LightEmission);
                Console.ReadLine();
            };
            
            astro.PropertyChanged += onPropertyChanged;

            astro.Name = "Earth";
            astro.Radius = 6371;
            astro.LightEmission = false;

            astro.Name = "Mars";

            astro.PropertyChanged -= onPropertyChanged;
            */

            // 2
            PlanetBook book = new PlanetBook();

            var mercury = new AstronomicalObjectEqual("Mercury", 2439, false);
            var venus = new AstronomicalObjectEqual("Venus", 6051, false);
            var earth = new AstronomicalObjectEqual("Earth", 6371, false);
            var mars = new AstronomicalObjectEqual("Mars", 3389, false);

            book.MaxRange = 3;

            EventHandler OnListMaxRangeReached = delegate {
                Console.WriteLine("Max Range");
                Console.ReadLine();
            };

            EventHandler OnListEmptyReached = delegate {
                Console.WriteLine("List Empty");
                Console.ReadLine();
            };

            book.ListMaxRangeReached += OnListMaxRangeReached;
            book.ListEmptyReached += OnListEmptyReached;

            book.AddAstronomicalObject(mercury, 1);
            book.AddAstronomicalObject(venus, 2);
            book.AddAstronomicalObject(earth, 3);
            book.AddAstronomicalObject(mars, 4);

            book.RemoveAstronomicalObject(mercury);
            book.RemoveAstronomicalObject(venus);
            book.RemoveAstronomicalObject(earth);
            book.RemoveAstronomicalObject(mars);

            book.ListMaxRangeReached -= OnListMaxRangeReached;
            book.ListEmptyReached -= OnListEmptyReached;

        }

    }
}
