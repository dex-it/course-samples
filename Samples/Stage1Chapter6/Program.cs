using System;
using System.Diagnostics;

namespace Stage1Chapter6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Packing example = new Packing();
            int[] arrInt = example.RetrieveInt();
            object[] arrObj = example.RetrieveObject();

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            example.Boxing(arrInt);
            stopWatch.Stop();
            Console.WriteLine("Упаковка: " + stopWatch.ElapsedMilliseconds);

            stopWatch.Reset();
            stopWatch.Start();
            example.UnBoxing(arrObj);
            stopWatch.Stop();
            Console.WriteLine("Распаковка: " + stopWatch.ElapsedMilliseconds);

            stopWatch.Reset();
            stopWatch.Start();
            example.Copy(arrInt);
            stopWatch.Stop();
            Console.WriteLine("Копирование: " + stopWatch.ElapsedMilliseconds);

            Console.ReadLine();

        }
    }
}
