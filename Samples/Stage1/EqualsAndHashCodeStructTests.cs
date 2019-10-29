using NUnit.Framework;

namespace Stage1
{
    public class EqualsAndHashCodeStructTests
    {
        [Test]
        public void PointEqualsTest()
        {
            Name figureName1 = new Name
            {
                Value = "Название фигуры"
            };

            Name figureName2 = new Name
            {
                Value = "Название фигуры"
            };
            
            Figure f1 = new Figure(1, 2, figureName1);
            Figure f2 = new Figure(1, 2, figureName2);
            Figure f3 = new Figure(3, 4, figureName1);

            Assert.IsTrue(f1.Equals(f2));
            Assert.IsFalse(f1.Equals(f3));
        }
    }

    struct Figure
    {
        public int Length { get; }
        public int Width { get; }
        public Name Name { get; set; }
        
        public Figure(int length, int width, Name name)
        {
            Length = length;
            Width = width;
            Name = name;
        }
    }

    class Name
    {
        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Name))
                return false;

            var name = (Name) obj;
            return name.Value == Value;
        }
    }
}