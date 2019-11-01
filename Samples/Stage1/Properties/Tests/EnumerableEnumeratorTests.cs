using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class EnumerableEnumeratorTests
    {
        [Test]
        public void EnumerableTest()
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }

            /* This code produces output similar to the following:
             *
             * John Smith
             * Jim Johnson
             * Sue Rabon
             *
             */
        }

        [Test]
        public void ModifyEnumerableListTest()
        {
            var list = new List<string>() {"hello", "world"};
            Assert.Catch<InvalidOperationException>(() =>
            {
                foreach (var el in list)
                {
                    list.Add("test");
                }
            });
        }
    }

    // Simple business object.
    public class Person
    {
        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public string FirstName;
        public string LastName;
    }

    // Collection of Person objects. This class
    // implements IEnumerable so that it can be used
    // with ForEach syntax.
    public class People : IEnumerable
    {
        private readonly Person[] _people;

        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class PeopleEnum : IEnumerator
    {
        public Person[] People;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int _position = -1;

        public PeopleEnum(Person[] list)
        {
            People = list;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < People.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return People[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}