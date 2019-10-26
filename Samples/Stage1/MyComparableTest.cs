using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ComparableTest
    {
        [Test]
        public void Test1()
        {

            Circle [] circles=new Circle[100];
            
            Random random=new Random();
    
            for (int i = 0; i < 100; i++)
            {
                circles[i]=new Circle {Square = random.Next(1,100)};
            }

            Array.Sort(circles);
            
            foreach (var circle in circles )
            {
                Console.WriteLine(circle.Square);
            }

        }
    }
    
    public class Circle:IComparable
    {
        public double Square { get; set; }

        public int CompareTo(object obj)
        {
        
            if (obj is Circle circle)
            {
                return Square.CompareTo(circle.Square);
            }
            else
            {
                throw new ArgumentException(String.Format(""));
            }
            
        }
    }
}