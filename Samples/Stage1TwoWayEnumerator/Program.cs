using System;
using System.Collections.Generic;

namespace Stage1TwoWayEnumerator
{
    class Program
    {
        private static void Main(string[] args)
        {
            //IEnumerator<T> enu = new IEnumerator<T>;
            //var enumerator = TwoWayEnumerator(enu);
            /*
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                // Do something
            }
            */

            int[] arr = { 1, 2, 3, 4, 5 };

            foreach (var a in arr)
            {
                Console.WriteLine($"{a}");
            }

        }

    }
}