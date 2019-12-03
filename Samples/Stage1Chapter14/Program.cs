using System;
using System.ComponentModel;

namespace Stage1Chapter14
{
    class Program
    {

        static void Main(string[] args)
        {
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
        }

    }
}
