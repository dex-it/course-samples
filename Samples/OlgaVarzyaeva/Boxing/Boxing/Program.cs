using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 10; i++) 
            {
                int n = 4;
                object c = n;//упаковка
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("На 10 циклов упаковки потрачено милисекунд: "+ts.TotalMilliseconds.ToString());
            stopWatch.Reset();
            stopWatch.Start();
            for (int j = 0; j < 10; j++)
            {                
                object o = 57;
                int p = (int)o;//распаковка
            }
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.WriteLine("На 10 циклов распаковки потрачено милисекунд: " + ts.TotalMilliseconds.ToString());
            Console.ReadKey();
        }
    }
}
