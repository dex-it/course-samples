using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Stage1.MyThreadsTest
{
    public class MyParallelTest
    {
        /// <summary>
        /// Генерировать и считать среднее арифметическое для массива размером в 10М и 100М элементов.
        /// Реализовать 2 варианта, параллельные вычисления и без них, оценить результаты
        /// </summary>
       
        int[,] mas = new int[10, 100];

        Random random = new Random();
        Stopwatch _sw;
        int _sum;
        double _average;

        [Test]
        public void FillMas()
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = random.Next(1, 100);
                }
            }
        }
        
        [Test]
        public void ParralelMeasure()
        {
            _sum = 0;
            _sw = new Stopwatch();
            _sw.Start();
            
//            _sum = mas.AsParallel()
//                      .Cast<int>()
//                      .Sum();

           // Parallel.ForEach<int>(mas.OfType<int>(), item => { _sum += item; });

            Parallel.For(0, mas.Length, i => { _sum += i; });
            
            
            _average = (double)_sum / mas.Length;
            
            _sw.Stop();

            Console.WriteLine("Parallel " + _sw.ElapsedTicks);

        }
      
        [Test]
        public void NonParallelMeasure()
        {
            FillMas();
            _sum = 0;
            _sw = new Stopwatch();
            _sw.Start();

//            _sum = mas.Cast<int>()
//                .Sum();

            foreach (var item in mas)
            {
                _sum += item;
            }
            _average = (double)_sum / mas.Length;

            _sw.Stop();

            Console.WriteLine("Non Parallel " + _sw.ElapsedTicks );
             
        }
    }
}