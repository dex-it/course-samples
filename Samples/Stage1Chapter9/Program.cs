using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter9
{
    class Program
    {
        private static readonly Random Rnd = new Random();

        private static decimal MakeValue()
        {
            decimal value;
            value = Rnd.Next(1, 100);

            return value;
        }



        static void Main(string[] args)
        {
            
            decimal value1;
            decimal value2;
            
            //value1 = MakeValue();
            //Circle circle = new Circle(value1);
            
            
            //value1 = MakeValue();
            //Square square = new Square(value1);
                       
            List<Rectangle> listRectangles = new List<Rectangle>();
            for (int i = 0; i < 10; i++)
            {
                value1 = MakeValue();
                value2 = MakeValue();
                
                Rectangle rectangle = new Rectangle(value1, value2);
                listRectangles.Add(rectangle);
            }


            //circle.Info();
            //square.Info();
            //rectangle.Info();

            listRectangles.Sort();

            foreach (Rectangle r in listRectangles)
            {
                r.Info();
            }




        }
    }
}
