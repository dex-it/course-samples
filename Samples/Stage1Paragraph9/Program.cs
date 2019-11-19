using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph9
{
    class Program
    {
        private static void PrintRectangles(string str, Rectangle[] rec)
        {
            Console.WriteLine(str);

            foreach (var e in rec)
            {
                Console.WriteLine($"Длина: {e.Length}, Ширина: {e.Width}, Площадь: {e.Square}");
            }
        }

        static void Main(string[] args)
        {
            var rectangles = new Rectangle[10];

            Random rnd1, rnd2;
            rnd1 = new Random();
            rnd2 = new Random();

            for (int i = 0; i < rectangles.Length; i++)
            {
                int length = rnd1.Next(0, 100);
                int width = rnd2.Next(0, 100);
                rectangles[i] = new Rectangle(length, width);
            }

            PrintRectangles("Неупорядоченный массив прямоугольников", rectangles);

            Array.Sort(rectangles);
            Array.Reverse(rectangles);

            PrintRectangles("\nУпорядоченный массив прямоугольников", rectangles);

            Console.ReadLine();
        }
    }
}
