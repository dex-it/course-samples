using System;
using NUnit.Framework;

namespace Stage1.ReflectionTest
{
    public class DeepCopyTest
    {
        [Test]
        public void CopyTest()
        {
            var person=new Person
            {
                Name = "PersonName",
                Car = new Car
                {
                    Number = "A456EK"
                }
            };

            Person personCopy = Copier.Copy(person) as Person ;
            
            Assert.AreNotEqual(person,personCopy);
            Assert.AreNotEqual(person.Car,personCopy.Car);

           string copy=(String)Copier.Copy("Original string");
            
        }

    }
}