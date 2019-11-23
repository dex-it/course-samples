using System;
using System.Globalization;


namespace Stage1Chapter10
{
    class Program
    {
        static void Main()
        {
            AstronomicalObjectEqual astroObject1 = new AstronomicalObjectEqual("Moon", 1737, false);
            AstronomicalObjectEqual astroObject2 = new AstronomicalObjectEqual("Moon", 1737, false);

            //astroObject2 = astroObject1;

            Console.WriteLine("astroObject1.Equals(astroObject2) == " + Convert.ToString(astroObject1.Equals(astroObject2), CultureInfo.InvariantCulture));
            Console.WriteLine("astroObject1.GetHashCode() == " + Convert.ToString(astroObject1.GetHashCode(), CultureInfo.InvariantCulture));
            Console.WriteLine("astroObject2.GetHashCode() == " + Convert.ToString(astroObject2.GetHashCode(), CultureInfo.InvariantCulture));

            Console.ReadLine(); 
        }
    }
}
