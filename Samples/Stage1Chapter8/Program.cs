using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter8
{
    class Program
    {

        private static readonly Random Rnd = new Random();

        private static string MakeName()
        {
            
            char c = new char();
            string name = "";
            while (name.Length < 10)
            {
                //while (name.Contains(c.ToString()))
                //{
                    //97, 122 - англ. алфавит
                    //1040, 1104 - русс. алфавит

                    c = (char)(Rnd.Next(97,122));
                //}
                name += c;
            }

            return name;
        }

        private static long MakeWeight()
        {
            long weight;
            weight = Rnd.Next(0, 10000000);

            return weight;
        }

        private static bool MakeLightEmission()
        {
            bool lightEmission;
            lightEmission = Convert.ToBoolean(Rnd.Next(0, 2));

            return lightEmission;
        }


        static void Main(string[] args)
        {
            AstronomicalObject[] astro = new AstronomicalObject[99];

            for (int i = 0; i < astro.Length; i++)
            {
                astro[i] = new AstronomicalObject(MakeName(), MakeWeight(), MakeLightEmission());
            }
          
            var astroSelected = astro.Where(a => a.Name.StartsWith("m") && !a.LightEmission).OrderBy(a => a.Weight);
            var sum = astro.Where(a => a.Name.StartsWith("m") && !a.LightEmission).Sum(a => a.Weight);

            long j = 0;
            foreach (AstronomicalObject a in astroSelected)
            {
                Console.WriteLine(j.ToString() + " - " + a.Name + " - " + Convert.ToString(a.LightEmission) + " - " + a.Weight.ToString());
                j++;
            }

            Console.WriteLine("Сумма масс планет = " + sum.ToString());

            Console.ReadLine();
        }
    }
}
