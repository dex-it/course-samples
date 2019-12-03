using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph9
{
    public class Rectangle : IComparable
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Square
        {
            get
            {
                return Length * Width;
            }
        }

        // для демонстрации рефлексии модификатор private
        private int privateProperty { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public void IncreaseLength(int value)
        {
            Length += value;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Длина:{Length}, Ширина: {Width}");
        }

        public void PrintPrivateProperty()
        {
            Console.WriteLine($"privateProperty = {privateProperty}");
        }

        public int CompareTo(object obj)
        {
            Rectangle rec = obj as Rectangle;
            if (this.Square < rec.Square) return -1;
            if (this.Square > rec.Square) return 1;
            return 0;
        }
    }
}
