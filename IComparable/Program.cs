using System;
using System.Collections.Generic;

namespace IComparable_interfase
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            Treugolnik[] tr = new Treugolnik[10];

            Console.WriteLine("Генерация");
            for (int i=0;i<tr.Length;i++)
            {
                tr[i] = new Treugolnik { Katet1 = random.Next(100), Katet2 = random.Next(100), Gipotenuza = random.Next(100) };
                Console.WriteLine("Треугольник с сторонами: Катет1=" + tr[i].Katet1 + "  Катет2=" + tr[i].Katet2 + "  Гипоьенуза=" + tr[i].Gipotenuza);
            }

            Console.WriteLine("Сортировка по гипотенузе");
            Array.Sort(tr);         
            foreach (Treugolnik t in tr)
            {
                Console.WriteLine("Треугольник с сторонами: Катет1="+t.Katet1+"  Катет2="+t.Katet2+"  Гипоьенуза="+t.Gipotenuza);
            }


            Console.WriteLine("Сортировка по площади");
            Array.Sort(tr, new TreugolnikComparer());
            foreach (Treugolnik t in tr)
            {
                Console.WriteLine("Треугольник с сторонами: Катет1=" + t.Katet1 + "  Катет2=" + t.Katet2 + "  Гипоьенуза=" + t.Gipotenuza + "  Площадь=" + t.Katet1*t.Katet2/2);

            }
            Console.ReadLine();
        }
    }


    class Treugolnik : IComparable
    {
        public int Katet1 { get; set; }
        public int Katet2 { get; set; }
        public int Gipotenuza { get; set; }
        public int CompareTo(object o)
        {
            Treugolnik t = o as Treugolnik;
            if (t != null)
                return this.Gipotenuza.CompareTo(t.Gipotenuza);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }


    }
    class TreugolnikComparer : IComparer<Treugolnik>
    {
        public int Compare(Treugolnik t1, Treugolnik t2)
        {
            if (t1.Katet1*t1.Katet2 > t2.Katet1 * t2.Katet2)
                return 1;
            else if (t1.Katet1 * t1.Katet2 < t2.Katet1 * t2.Katet2)
                return -1;
            else
                return 0;
        }
    }
}
