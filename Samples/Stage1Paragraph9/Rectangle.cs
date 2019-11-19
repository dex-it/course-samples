using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph9
{
    class Rectangle : IComparable
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

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
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
