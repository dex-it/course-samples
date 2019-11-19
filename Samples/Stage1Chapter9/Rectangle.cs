using System;
using System.Globalization;

namespace Stage1Chapter9
{
    public class Rectangle:GeometricShape
    {
        decimal Height { get; }
        decimal Width { get; }

        protected virtual string Name => "Прямоугольник";

        public Rectangle(decimal height = 0, decimal width = 0)
        {
            Height = height;
            Width = width;
        }
        public override decimal Area => Height * Width;

        public void Info()
        {
            Console.WriteLine("Геометрическая фигура: " + Name);
            Console.WriteLine("Высота: " + Height.ToString(CultureInfo.InvariantCulture) + ", ширина: " + Width.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Площадь: " + Area.ToString(CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
