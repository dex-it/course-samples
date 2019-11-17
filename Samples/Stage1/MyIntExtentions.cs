using System;
using NUnit.Framework;

namespace Stage1
{
    //        Реализовать методы расширения для класса int, 
    //        для операций над TimeSpan. Например 1,Seconds() = (TimeSpan) 00.00.01;

    public static class MyIntExtentions
    {
        public static TimeSpan Seconds(this int i)
        {
            return TimeSpan.FromSeconds(i);
        }
    }

    public class MyIntExstentionTest
    {
        [Test]
        public void IntExstentionTest()
        {
            Assert.AreEqual(1.Seconds(),new TimeSpan(00,00,01));
        }
    }
}