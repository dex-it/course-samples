using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _9___IComparable
{
    interface IComparer
    {
        int Compare(object o1, object o2);
    }
    class Circle : IComparable
    {
        public Circle() { }
        public Circle(double r)
        {
            R = r;
        }
        public double R { get; set; }
        public double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public int CompareTo(object obj)
        {
            Circle other = obj as Circle;
            if (other != null)

            {
                if (this.Square() > other.Square())
                    return 1;
                if (this.Square() < other.Square())
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not a Circle");
        }
    }

    class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.Square() > c2.Square())
                return 1;
            else if (c1.Square() < c2.Square())
                return -1;
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ArrayList circles1 = new ArrayList();
            for (int i = 0; i < 10;i++)
            {
                circles1.Add(new Circle(rnd.Next(1,10)+rnd.NextDouble()));
            }
            circles1.Sort();
            Console.WriteLine("Отсортированный список из 10 кругов по площади (Icomparable)");
            foreach (Circle c in circles1)
                Console.WriteLine("Square:"+c.Square());

            Circle[] circles2 = new Circle[10];
            for (int i = 0; i < circles2.Length; i++)
            {
                circles2[i]=new Circle(rnd.Next(1, 10) + rnd.NextDouble());
            }
            Array.Sort(circles2, new CircleComparer());
            Console.WriteLine("\nОтсортированный список из 10 кругов по площади (IComparer)");
            foreach (Circle c in circles2)
                Console.WriteLine("Square:" + c.Square());
            Console.ReadLine();
        }
    }
}


