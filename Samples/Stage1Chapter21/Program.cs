using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Stage1Chapter21
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadingMeasure threadMeasure1 = new ThreadingMeasure();
            ThreadingMeasure threadMeasure2 = new ThreadingMeasure();

            long startValue = 1;
            long quantityNumbers = 1000000;

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            long avg1 = threadMeasure1.AvgWithotThreads(startValue, quantityNumbers);
            stopWatch.Stop();
            Console.WriteLine($"Среднее от {startValue} до {quantityNumbers + startValue - 1} = {avg1}");
            Console.WriteLine($"Время выполнения: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"sumFirstHalf: {threadMeasure1.sumFirstHalf}, sumSecondHalf: {threadMeasure1.sumFirstHalf}");
            Console.WriteLine("");



            stopWatch.Start();
            long avg2 = threadMeasure2.AvgWithThreads(startValue, quantityNumbers);
            stopWatch.Stop();
            Console.WriteLine($"Среднее от {startValue} до {quantityNumbers + startValue - 1} = {avg2}");
            Console.WriteLine($"Время выполнения: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"sumFirstHalf: {threadMeasure2.sumFirstHalf}, sumSecondHalf: {threadMeasure2.sumFirstHalf}");
            Console.ReadLine();

        }


    }
}
