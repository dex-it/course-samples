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
            try
            {
                Assembly asm = Assembly.LoadFrom("Stage1Chapter14.exe");
                Type t = asm.GetType(typeof(AstronomicalObject).FullName);
                
                object[] obj = new object[] { "Earth", (decimal)6371, false };

                ConstructorInfo constructor = t.GetConstructor(new[] { typeof(string), typeof(decimal), typeof(bool) });
                object astroObject = constructor.Invoke(obj);

                MethodInfo method = t.GetMethod("GetSurfaceArea");

                object result = method.Invoke(astroObject, new object[] {});
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            


        }
    }
}
