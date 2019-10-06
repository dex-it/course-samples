using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void StringExtensionsTests()
        {
            string s = "Привет, мир!";
            int i = s.WordCount();
            Assert.AreEqual(2, i);

            Console.WriteLine(i);

            //Output:

            //2
        }
    }

    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            return str.Split(new char[] { ' ', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}