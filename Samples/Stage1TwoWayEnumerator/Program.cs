using System;
using System.Collections.Generic;

namespace Stage1TwoWayEnumerator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            foreach (var a in arr)
            {
                Console.WriteLine($"{a}");
            }

        }

    }
}