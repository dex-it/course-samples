using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Stage1
{
    public class MyRegexTest
    {
        [Test]
        public void Test1()
        {
            string s = "1000 10000 1  002 2 1 000 000 2 2 100.23 2";
            var regex=new Regex("([1]([0]{3} |[0]{4}\\s| [0]{3} [0]{3} |[0]{2}[.][2][3]))");
            
            var matchCollection = regex.Matches(s);
            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }
        }
        
        [Test]
        public void Test2()
        {
            var s = "+373 61000 363 10000 1  002 2 1 000 000 2 2 100.23 2";
            var phoneRegex=new Regex("@(\\'+'373) | 363");
            
            var matchCollection = phoneRegex.Matches(s);
            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}