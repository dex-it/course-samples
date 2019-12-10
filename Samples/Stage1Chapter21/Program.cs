using System;
using System.Diagnostics;
using System.Threading;

namespace Stage1Chapter21
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadingMeasure threadMeasure = new ThreadingMeasure();


            long startValue = 1;
            long quantityNumbers = 10000000;

            Stopwatch stopWatch = new Stopwatch();

            Thread.Sleep(100);
            stopWatch.Reset();
            stopWatch.Start();
            double avg1 = threadMeasure.AvgWithoutThreads(startValue, quantityNumbers);
            stopWatch.Stop();
            Console.WriteLine($"Среднее от {startValue} до {quantityNumbers + startValue - 1} = {avg1}");
            Console.WriteLine($"Время выполнения: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"sumFirstHalf: {threadMeasure.GetSumFirstHalf()}, sumSecondHalf: {threadMeasure.GetSumSecondHalf()}");
            Console.WriteLine("");

            Thread.Sleep(100);
            stopWatch.Reset();
            stopWatch.Start();
            double avg2 = threadMeasure.AvgWithThreads(startValue, quantityNumbers);
            stopWatch.Stop();
            Console.WriteLine($"Среднее от {startValue} до {quantityNumbers + startValue - 1} = {avg2}");
            Console.WriteLine($"Время выполнения: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"sumFirstHalf: {threadMeasure.GetSumFirstHalf()}, sumSecondHalf: {threadMeasure.GetSumSecondHalf()}");
            Console.WriteLine("");

            Thread.Sleep(100);
            stopWatch.Reset();
            stopWatch.Start();
            double avg3 = threadMeasure.AvgParallelInvoke(startValue, quantityNumbers);
            stopWatch.Stop();
            Console.WriteLine($"Среднее от {startValue} до {quantityNumbers + startValue - 1} = {avg3}");
            Console.WriteLine($"Время выполнения: {stopWatch.ElapsedMilliseconds}");
            Console.WriteLine($"sumFirstHalf: {threadMeasure.GetSumFirstHalf()}, sumSecondHalf: {threadMeasure.GetSumSecondHalf()}");
            Console.WriteLine("");

            
            Console.ReadLine();

        }


    }
}
