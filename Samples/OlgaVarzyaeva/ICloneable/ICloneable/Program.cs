using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable
{
    public interface ICloneable
    {
        object Clone();
    }
    struct Flat : ICloneable
    {
        public int Stage { get; set; }
        public int Number { get; set; }     
        public Room Room1 { get; set; }
        public object Clone()
        {
            Room room1 = new Room { A = this.Room1.A, B=this.Room1.B };//для глубокого копирования
            return new Flat
            {
                Stage = this.Stage,
                Number = this.Number,
                Room1 = room1
            };
            //return this.MemberwiseClone(); поверхностное копирование
        }

    }

    class Room
    {
        public Room() { }
        public Room (double a, double b)
        {
            A = a;
            B = b;

        }
        public double A { get; set; }
        public double B { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat { Stage=4, Number = 48, Room1=new Room(5.1,8.15) };
            Flat f2 = (Flat)f1.Clone();
            f2.Stage = 3;
            f2.Number = 59;
            f2.Room1.A = 7.85;
            f2.Room1.B = 6.45;            
            Console.WriteLine("f1: Stage - " + f1.Stage +", Number - " + f1.Number + ". Room1: A - " + f1.Room1.A + ", B - " + f1.Room1.B);
            Console.WriteLine("f2: Stage - " + f2.Stage +", Number - " + f2.Number + ". Room1: A - " + f2.Room1.A + ", B - " + f2.Room1.B);
            Console.ReadKey();

        }
    }
}
