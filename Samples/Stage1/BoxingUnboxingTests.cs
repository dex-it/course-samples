using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class BoxingUnboxingTests
    {
        [Test]
        public void BoxingTest()
        {
            int i = 123;
            object o = i; //упаковка
            Assert.AreEqual(123, o);
        }

        [Test]
        public void UnboxingTest()
        {
            object o = 123; 
            int i = (int) o; //распаковка

            Assert.AreEqual(123, i);
        }

        [Test]
        public void Unboxing_ThrowInvalidCastException_Test()
        {
            int i = 123;
            object o = i; //упаковка

            Assert.Throws<InvalidCastException>(() =>
            {
                int s = (short)o; //попытка распаковки
            });
        }
    }
}