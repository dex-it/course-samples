using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class RegularExpressionTests
    {
        [Test]
        public void Regex_IsMatch_ReturnTrue()
        {
            string value = "111-22-3333";
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            bool isMatch = Regex.IsMatch(value, pattern);
            Assert.IsTrue(isMatch);
        }

        [Test]
        public void Regex_IsMatch_ReturnFalse()
        {
            string value = "111-2-3333";
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            bool isMatch = Regex.IsMatch(value,  pattern);
            Assert.IsFalse(isMatch);
        }

        [Test]
        public void Regex_Matches_Test()
        {
            string input = "This is a a farm that that raises dairy cattle.";
            string pattern = @"\b(\w+)\W+(\1)\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            Assert.AreEqual(2, matches.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine("Duplicate '{0}' found at position {1}.",
                    match.Groups[1].Value, match.Groups[2].Index);
            }

            //Output:

            //Duplicate 'a' found at position 10.
            //Duplicate 'that' found at position 22.
        }

        [Test]
        public void Regex_Replace_Test()
        {
            string pattern = @"\b\d+\.\d{2}\b";
            string replacement = "$$$&";
            string input = "Total Cost: 103.64";
            string output = Regex.Replace(input, pattern, replacement);
            Assert.AreEqual("Total Cost: $103.64", output);
            Console.WriteLine(output);

            //Output:

            //Total Cost: $103.64
        }
    }
}