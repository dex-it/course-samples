using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ValueAndReferenceTypeTests
    {
        [Test]
        public void CopyValueTypesTest()
        {
            State state1 = new State();
            Assert.AreEqual(0, state1.X);
            Assert.AreEqual(0, state1.Y);

            State state2 = new State();
            state2.X = 1;
            state2.Y = 2;
            Assert.AreEqual(1, state2.X);
            Assert.AreEqual(2, state2.Y);

            state1 = state2; // копирование значений
            Assert.AreEqual(1, state1.X);
            Assert.AreEqual(2, state1.Y);

            state2.X = 5;
            Assert.AreEqual(5, state2.X);
            Assert.AreEqual(1, state1.X); // state1.x == 1 по-прежнему
        }

        [Test]
        public void CopyReferenceTypesTest()
        {
            Country country1 = new Country();
            Assert.AreEqual(0, country1.X);
            Assert.AreEqual(0, country1.Y);

            Country country2 = new Country();
            country2.X = 1;
            country2.Y = 2;
            Assert.AreEqual(1, country2.X);
            Assert.AreEqual(2, country2.Y);

            country1 = country2;
            Assert.AreEqual(1, country1.X);
            Assert.AreEqual(2, country1.Y);

            country2.X = 5;
            Assert.AreEqual(5, country2.X);
            Assert.AreEqual(5, country1.X); // country1.x == 5, так как country1 и country2 указывают на один объект в куче
        }

        [Test]
        public void ValueTypeAsMethodParameterTest()
        {
            var i = 0;
            ChangeValue(i); //передается копия значения
            Assert.AreEqual(0, i);
        }

        [Test]
        public void ReferenceTypeAsMethodParameterTest()
        {
            Person p = new Person { Name = "Tom", Age = 23 };
            Assert.AreEqual("Tom", p.Name);
            ChangePerson(p); //передается копия ссылки
            Assert.AreEqual("Alice", p.Name);
        }

        [Test]
        public void ReferenceTypeAsPartOfValueTypeTest()
        {
            State state1 = new State();
            state1.Country = new Country();
            state1.Country.X = 1;

            State state2 = new State();
            state2.Country = new Country();
            state2.Country.X = 5;

            // state1.Country и state2.Country ссылаются на разные объекты в куче
            Assert.AreEqual(1, state1.Country.X);
            Assert.AreEqual(5, state2.Country.X);


            state1 = state2; //копирование
            state2.Country.X = 8;

            // state1 и state2 - это копии, а не одно и тоже значение,
            // state1.Country и state2.Country - копии ссылочной переменной, ссылающихся на один объект в куче
            Assert.AreEqual(8, state1.Country.X);
            Assert.AreEqual(8, state2.Country.X);
        }


        private void ChangePerson(Person person)
        {
            //person указывает на тот же объект в куче, что и ссылочная переменная из вызывающего кода,
            //но это не та же ссылочная переменная, а ее копия
            person.Name = "Alice"; 
            person = new Person { Name = "Bill", Age = 45 }; // здесь ссылочная переменная указывает уже на другой объект, а ссылочная переменная из вызывающего кода на прежний
            Console.WriteLine(person.Name); // Bill
        }

        private void ChangeValue(int i)
        {
            i = 5; // меняется копия значения, а не значение из вызывающего кода
            Console.WriteLine(i); // 5
        }


        struct State
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Country Country { get; set; }
        }

        class Country
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}