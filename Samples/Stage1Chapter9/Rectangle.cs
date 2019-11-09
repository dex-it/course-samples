using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter9
{
    class Rectangle:GeometricShape
    {
        decimal Height { get; set; }
        decimal Width { get; set; }
        private const string name = "Прямоугольник";

        protected virtual string Name
        {
            get
            {
                return name;
            }
        }

        public Rectangle(decimal height = 0, decimal width = 0)
        {
            Height = height;
            Width = width;
        }
        public override decimal Area
        {
            get
            {
                return Height * Width;
            }
            
        }

        public override void Info()
        {
            Console.WriteLine("Геометрическая фигура: " + Name);
            Console.WriteLine("Высота: " + Height.ToString() + ", ширина: " + Width.ToString());
            Console.WriteLine("Площадь: " + Area.ToString());
            Console.ReadLine();
        }
    }
}
