using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph6
{
    class Program
    {
        static void Main(string[] args)
        {
            int testArrayLength = 10_000_000;
            var sourceIntNumbers = new int[testArrayLength];
            var receiverIntNumbers = new int[testArrayLength];
            var boxedNumbers = new object[testArrayLength];
            var unboxedIntNumbers = new int[testArrayLength];

            Console.WriteLine($"Тесты простого копирования, упаковки и распаковки в миллисекундах " +
                $"для массивов целых чисел длиной {testArrayLength}");

            // Тест простого копирования
            var watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < testArrayLength; i++)
            { receiverIntNumbers[i] = sourceIntNumbers[i]; }

            watch.Stop();
            Console.WriteLine($"Простое копирование: {watch.ElapsedMilliseconds}");

            // Тест упаковки
            watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < testArrayLength; i++)
            { boxedNumbers[i] = sourceIntNumbers[i]; }

            watch.Stop();
            Console.WriteLine($"Упаковка: {watch.ElapsedMilliseconds}");

            // Тест распаковки
            watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < testArrayLength; i++)
            { unboxedIntNumbers[i] = (int)boxedNumbers[i]; }

            watch.Stop();
            Console.WriteLine($"Распаковка: {watch.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}
