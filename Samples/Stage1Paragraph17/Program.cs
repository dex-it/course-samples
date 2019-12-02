using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph17
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 50;

            Console.WriteLine(time.Seconds());
            Console.WriteLine(time.Minutes());
            Console.WriteLine(time.Hours());
            Console.WriteLine(time.Days());
            Console.ReadLine();
        }
    }
}