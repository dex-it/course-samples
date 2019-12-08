using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stage1Chapter21
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(WriteY);
            t.Start();
            while (true)
            {
                Console.Write("x");
            }
        }

        static void WriteY()
        {
            while (true)
            {
                Console.Write("y");
            }
        }
    }
}
