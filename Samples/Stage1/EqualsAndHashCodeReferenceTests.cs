using NUnit.Framework;

namespace Stage1
{
    public class EqualsAndHashCodeReferenceTests
    {
        [Test]
        public void FigureEqualsTest()
        {
            Figure f1 = new Figure (10, 20);
            Figure f2 = new Figure (10, 20);
            Figure f3 = new Figure (20, 30);
            Figure f4 = f1;
            
            Assert.IsTrue(f1.Equals(f2));
            Assert.IsFalse(f1.Equals(f3));
            Assert.IsFalse(f1 == f2);
            Assert.IsTrue(f1 == f4);
        }

        [Test]
        public void ObjectFigureEqualsTest()
        {
            object o1 = new object();
            object o2 = new object();
            object o3 = o1;

            Assert.IsTrue(o1 == o3);
            Assert.IsFalse(o1 == o2);
        }

        [Test]
        public void FigureGetHashCodeTest()
        {
            Figure f1 = new Figure (10, 20);
            Figure f2 = new Figure (10, 20);
            Figure f3 = new Figure (20, 30);
            
            Assert.AreEqual(30, f1.GetHashCode());
            Assert.AreEqual(30, f2.GetHashCode());
            Assert.AreEqual(50, f3.GetHashCode());
        }
        
        private class Figure
        {
            public int Length { get; }
            public int Width { get; }
 
            public Figure(int length, int width)
            {
                Length = length;
                Width = width;
            }
 
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                if (!(obj is Figure))
                    return false;

                var figure = (Figure) obj;
                return figure.Length == Length && figure.Width == Width;
            }
        
            public override int GetHashCode()
            {
                return Length + Width;
            }
        }
    }
}