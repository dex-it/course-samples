using System;
using System.Collections.Generic;

namespace TestIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            SomeFigure[] someFigures = new SomeFigure[10];

            for (int i = 0; i<10; i++)
            {
                someFigures[i] = new SomeFigure(rnd.Next(1, 10), rnd.Next(1, 10));
            }
            Console.WriteLine("Сортируем по площади");
            Array.Sort(someFigures);
            Print(someFigures);

            Console.WriteLine(new string('-', 32));

            Console.WriteLine("Сортируем по стороне a");
            Array.Sort(someFigures, new CompareSomeFigureToA());
            Print(someFigures);

            Console.ReadLine();
        }

        public static void Print(SomeFigure[] someFigures)
        {
            foreach (var someFigure in someFigures)
            {
                Console.WriteLine("a = {0} b = {1} area = {2}", someFigure.A, someFigure.B, someFigure.Area);
            }
        }
    }
}
