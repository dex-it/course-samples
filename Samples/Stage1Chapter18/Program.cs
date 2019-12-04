using System;
using System.Reflection;
using System.Runtime.Remoting;
using Stage1Chapter14;

namespace Stage1Chapter18
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            AstronomicalObject astro = new AstronomicalObject("Earth", 6371, false);

            ReflectionTest reflection = new ReflectionTest();

            foreach (var s in reflection.GetConstructors(astro))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");

            foreach (var s in reflection.GetProperties(astro))
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();


            // 2

            Console.WriteLine(typeof(AstronomicalObject).FullName);
            ObjectHandle oh = Activator.CreateInstanceFrom(Assembly.GetEntryAssembly().CodeBase, typeof(AstronomicalObject).FullName);
            AstronomicalObject st = (AstronomicalObject)oh.Unwrap();

            Console.WriteLine(st.GetSurfaceArea());
            Console.ReadLine();




        }
    }
}
