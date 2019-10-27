using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Stage1
{
    //UI ?
    public class MyDictionaryTests
    {
        private class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDay { get; set; }
            public string Birthplace { get; set; }
        }

        private Dictionary<Person, string> _persons = new Dictionary<Person, string>();

        private KeyValuePair<Person, string> FindPerson(string firstName, string lastName, DateTime birthDay, string birthplace)
        {
            return _persons.FirstOrDefault(p => p.Key.FirstName == firstName &&
                                                p.Key.LastName == lastName &&
                                                p.Key.Birthplace == birthplace &&
                                                p.Key.BirthDay.Equals(birthDay));
        }


        [Test]
        public void Test() // UI, console ?
        {
            var person1 = new Person
            {
                FirstName = "Tom",
                LastName = "Taylor",
                Birthplace = "Canada",
                BirthDay = DateTime.Today
            };

            var person2 = new Person
            {
                FirstName = "Bob",
                LastName = "Williams",
                Birthplace = "USA",
                BirthDay = DateTime.Today
            };

            _persons.Add(person1, "WorkPlace1");
            _persons.Add(person2, "WorkPlace2");


            var findedPerson = FindPerson(person1.FirstName, person1.LastName, person1.BirthDay, person1.Birthplace);

            Assert.AreEqual("WorkPlace1", findedPerson.Value);


            findedPerson = FindPerson("WrongName", person1.LastName, person1.BirthDay, person1.Birthplace);

            Assert.IsNull(findedPerson.Value);
        }
    }
}