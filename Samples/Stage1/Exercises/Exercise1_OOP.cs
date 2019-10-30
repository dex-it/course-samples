using System;
using NUnit.Framework;

namespace Stage1.Exercises
{
    [TestFixture]
    public class Exercise1_OOP
    {
        [Test]
        public void OOPTest()
        {
            //Console.WriteLine("Enter the first side of the geometrical figure: ");
            //int.TryParse(Console.ReadLine(), out int side1);
            //Console.WriteLine("Enter the second side: ");
            //int.TryParse(Console.ReadLine(), out int side2);
            int side1 = 10, side2 = 20;

            if (side1 <= 0 || side2 <= 0)
            {
                Console.WriteLine("Wrong number!");
            }
            else if (side1 == side2)
            {
                var square = new Square("Square");
                square.Show(side1, side2);
            }
            else
            {
                var rectangle = new Rectangle("Rectangle");
                rectangle.Show(side1, side2);
            }
        }
        
        public abstract class GeometricalFigure
        {
            public string FigureName { get; set; }

            protected GeometricalFigure(string figureName)
            {
                FigureName = figureName;
            }

            public void Show(int side1, int side2)
            {
                Console.WriteLine($"{FigureName}'s Perimeter: {Perimeter(side1, side2)}, Area: {Area(side1, side2)}");
            }

            protected abstract int Perimeter(int side1, int side2);
            protected abstract int Area(int side1, int side2);
        }
        
        class Square: GeometricalFigure
        {
            public Square(string figyreName) : base(figyreName)
            {
            }

            protected override int Perimeter(int side1, int side2)
            {
                return (side1 *4);
            }

            protected override int Area(int side1, int side2)
            {
                return (side1 * side2);
            }
        }
        
        class Rectangle: Square
        {
            public Rectangle(string figureName): base(figureName) {}

            protected override int Perimeter(int side1, int side2)
            {
                return ((side1 + side2) * 2);
            }
        }
    }
}