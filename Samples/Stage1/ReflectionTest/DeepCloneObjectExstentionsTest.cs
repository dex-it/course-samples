using System;
using System.CodeDom;
using NUnit.Framework;

namespace Stage1.ReflectionTest
{
    public class DeepCloneTest
    {
        [Test]
        public void Test()
        {
            Person person = new Person
            {
                Car = new Car
                {
                    Engine = new Engine
                    {
                        TypeEngine = TypeEngine.Electric
                    }
                }
            };


            Person personCopy = person.DeepClone() as Person;

            Assert.AreNotEqual(person, personCopy);

            Assert.AreNotEqual(person.Car.Engine, personCopy.Car.Engine);

        }
        
        
        public class Person
        {
            public Car Car { get; set; }
        }

        public class Car
        {
            public Engine Engine { get; set; }
        }

        public class Engine
        {
            public TypeEngine TypeEngine { get; set; }
        }

        public enum TypeEngine
        {
            Electric,
            Gibrid
        }

    }
}