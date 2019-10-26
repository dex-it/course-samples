using System;
using NUnit.Framework;

namespace Stage1
{
    public class MyEqualsAndHashCodeReferenceTests
    {
        public class Person
        {
            public int PassportId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDay { get; set; }
            public string Birthplace { get; set; }

            
            public override bool Equals(object obj)
            {
                if (obj==null)
                {
                    return false;
                }

                if (!(obj is Person))
                {
                    return false;
                }
                
                var person = (Person)obj;
                return (
                    this.FirstName == person.FirstName &
                    this.LastName==person.LastName  &
                    this.PassportId==person.PassportId &
                    this.Birthplace==person.Birthplace &
                    this.BirthDay.Equals(person.BirthDay)
                );
            }

            public override int GetHashCode()
            {
                return PassportId.GetHashCode();
            }

        }
        
        [Test]
        public void EqualsTest()
        {
            var person1 = new Person
            {
                PassportId =1,
                FirstName = "Tom",
                LastName = "Taylor",
                Birthplace = "Canada",
                BirthDay = DateTime.Today
            };
                
            var person2 = new Person
            {
                PassportId =2,
                FirstName = "Bob",
                LastName = "Williams",
                Birthplace = "USA",
                BirthDay = DateTime.Today
            };
                
            var person3 = new Person
            {
                PassportId =person2.PassportId,
                FirstName = person2.FirstName,
                LastName = person2.LastName,
                Birthplace = person2.Birthplace,
                BirthDay = person2.BirthDay
            };
            
            Assert.AreNotEqual(person1.GetHashCode(),person2.GetHashCode());
            person1.PassportId = person2.PassportId;
            Assert.AreEqual(person1.GetHashCode(),person2.GetHashCode());

            Assert.IsFalse(person1.Equals(person2));
            person1 = person2;
            Assert.IsTrue(person1.Equals(person2));
            
            Assert.IsTrue(person2.Equals(person3));
            //Assert.IsFalse(person2.Equals(person3));

        }
    }
}