using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace Stage1
{
    public class MyCastingTest
    {
        private class Person
        {
            public string FirstName { get; set; }
            
            public string LastName { get; set; }

            public static implicit operator string(Person person)
            {
                return person.ToString();
            }

            public static explicit operator Person(string s)
            {
                try
                {
                    var mas = s.Split(' ');

                    return new Person
                    {
                        FirstName = mas[0],
                        LastName = mas[1]
                    };
                }
                catch (ArgumentException argumentException)
                {
                    Console.WriteLine(argumentException.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                return null;
            }
            
            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
        }

        [Test]
        public void Test()
        {
            var person = new Person
            {
                FirstName = "Иванов",
                LastName = "Иван"
            };
            
            Assert.IsTrue(string.Equals(person, "Иванов Иван"));
            Assert.IsTrue(person == "Иванов Иван");

            
            Assert.AreNotEqual(person,"Иванов Иван");
           
            string str = person;
            person = (Person)str;
            
            
        }

    }
}