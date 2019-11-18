using System;
using System.Collections.Generic;

namespace Stage1Chapter9
{
    public static class Program
    {
        private static readonly Random Rnd = new Random();

        private static decimal MakeValue() => Rnd.Next(1, 100);
        
        private static void Main(string[] args)
        {
            var listRectangles = new List<Rectangle>();
            
            for (var i = 0; i < 10; i++)
            {
                var value1 = MakeValue();
                var value2 = MakeValue();
                
                var rectangle = new Rectangle(value1, value2);
                listRectangles.Add(rectangle);
            }

            listRectangles.Sort();

            foreach (var r in listRectangles)
            {
                r.Info();
            }

        }
    }
}
