using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter9
{
    class Circle:GeometricShape
    {
        public decimal Radius { get; set; }
        private const string name = "Круг";
        public string Name => name;

        public Circle(decimal radius = 0)
        {
            Radius = radius;
        }
        public override decimal Area
        {
            get
            {
                return (Decimal)Math.PI * Radius * Radius;
            }
            
        }

        public override void Info()
        {
            Console.WriteLine("Геометрическая фигура: " + Name);
            Console.WriteLine("Радиус: " + Radius.ToString());
            Console.WriteLine("Площадь: " + Area.ToString());
            Console.ReadLine();
        }
    }
}
