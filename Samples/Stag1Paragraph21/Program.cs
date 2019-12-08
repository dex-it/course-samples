using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stag1Paragraph21
{
    class Program
    {
        private static void CalcAvgInArray()
        {
            int[] intArray = new int[100_000_000];
            Random rand = new Random();
            int monoAvg, parallelAvg = 0;
            Stopwatch watch = new Stopwatch();


            watch.Start();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rand.Next(10);
            }
            watch.Stop();
            Console.WriteLine($"Заполнение массива: {watch.ElapsedMilliseconds} миллисекунд");

            watch.Restart();
            monoAvg = intArray.Sum() / 100_000_000;
            watch.Stop();
            Console.WriteLine($"Вычисление среднего арифметического({monoAvg}) в однопоточном режиме: {watch.ElapsedMilliseconds} миллисекунд");

            watch.Restart();
            parallelAvg = intArray.AsParallel().Sum() / 100_000_000;
            watch.Stop();
            Console.WriteLine($"Вычисление среднего арифметического({parallelAvg}) в параллельном режиме: {watch.ElapsedMilliseconds} миллисекунд");
        }

        static void Main(string[] args)
        {
            CalcAvgInArray();
            Console.ReadLine();
        }
    }
}
