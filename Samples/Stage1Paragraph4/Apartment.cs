using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stag1Paragraph4
{
    public enum CompassPoints
    {
        Север,
        Юг,
        Запад,
        Восток
    }

    public class Apartment : ICloneable
    {
        public int Floor { get; set; }
        public double Square { get; set; }
        public int RoomCount { get; set; }
        public bool HasBalcony { get; set; }
        public CompassPoints WindowsOverlooking { get; set; }

        public Apartment() { }
        public Apartment(int floor, double square, int roomCount, bool hasBalcony,
            CompassPoints windowsOverlooking)
        {
            Floor = floor;
            Square = square;
            RoomCount = roomCount;
            HasBalcony = hasBalcony;
            WindowsOverlooking = windowsOverlooking;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Этаж: {Floor}," +
                $"\nПлощадь: {Square}," +
                $"\nКоличество комнат: {RoomCount}," +
                $"\nНаличие балкона: {HasBalcony}," +
                $"\nОкна выходят на: {WindowsOverlooking}");
        }

        public object Clone()
        {   // 1-й способ
            return new Apartment(this.Floor, this.Square, this.RoomCount, this.HasBalcony,
                this.WindowsOverlooking);

            // 2-й способ
            //return this.MemberwiseClone();
        }
    }
}
