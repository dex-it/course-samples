using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class TypeConversionTests
    {
        [Test]
        public void ImplicitValueTypeConversionTest()
        {
            int i = 2147483647;
            long l = i;

            Assert.AreEqual(2147483647, l);
        }

        [Test]
        public void ImplicitReferenceTypeConversionTest()
        {
            Derived d = new Derived();
            Base b = d;

            Assert.AreEqual(b.GetType().Name, "Derived");
            Assert.AreEqual(d.GetType().Name, "Derived");
        }

        [Test]
        public void ExplicitValueTypeConversionTest()
        {
            double d = 1234.7;
            int i = (int) d;

            Assert.AreEqual(1234, i);
        }

        [Test]
        public void ExplicitReferenceTypeConversionTest()
        {
            Derived d = new Derived();
            Base b = d;
            Derived d1 = (Derived) b;

            Assert.AreEqual(b.GetType().Name, "Derived");
            Assert.AreEqual(d.GetType().Name, "Derived");
            Assert.AreEqual(d1.GetType().Name, "Derived");
        }

        [Test]
        public void TypeConversion_ThrowsInvalidCastException()
        {
            Derived d = new Derived();
            Assert.Throws<InvalidCastException>(() =>
            {
                AnotherDerived anotherD = AnotherDerived.ToAnotherDerived(d);
            });
        }


        class Base { }

        class Derived : Base { }

        class AnotherDerived : Base
        {
            public static AnotherDerived ToAnotherDerived(Base @base)
            {
                return (AnotherDerived) @base;
            }
        }
    }
}