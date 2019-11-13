using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph7
{
    class Program
    {
        static void Main(string[] args)
        {
            TransnistriaTowns ourTowns = new TransnistriaTowns();

            Console.WriteLine("Вывод городов, используя цикл foreach:");

            foreach (string town in ourTowns)
            {
                Console.WriteLine(town);
            }

            Console.WriteLine("\nВывод городов, используя цикл while:");

            IEnumerator ie = ourTowns.GetEnumerator();

            while (ie.MoveNext())
            {
                string town = (string)ie.Current;
                Console.WriteLine(town);
            }

            Console.ReadKey();
        }
    }
}
