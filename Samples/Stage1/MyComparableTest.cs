using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Stage1
{
    public class Circle:IComparable<Circle>
    {
        public double Square { get; set; }

        public int CompareTo(Circle circle)
        {
            if (circle == null)
            {
                throw new ArgumentNullException(nameof(circle));
            }
            return this.Square.CompareTo(circle.Square);
        }
    }

    public class CircleComparer:IComparer<Circle>
    {
        public int Compare(Circle circle1, Circle circle2)
        {
            if (circle1 == null) throw new ArgumentNullException(nameof(circle1));
            if (circle2 == null) throw new ArgumentNullException(nameof(circle2));

            if (circle1.Square>circle2.Square)
                return 1;
            else if (circle1.Square<circle2.Square)
                return -1;
            else
                return 0;
        }

    }
    
    [TestFixture]
    public class MyComparableTest
    {
        [Test]
        public void Test1()
        {
            var circles=new Circle[100];
            
            var random=new Random();
    
            for (var i = 0; i < 100; i++)
            {
                circles[i]=new Circle {Square = random.Next(1,100)};
            }

            Array.Sort(circles);
            Array.Sort(circles,new CircleComparer());
            
            foreach (var circle in circles )
            {
                Console.WriteLine(circle.Square);
            }

        }
    }
}