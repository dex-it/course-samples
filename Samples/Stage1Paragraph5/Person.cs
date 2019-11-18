using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph5
{
    class Person
    {
        public Person(string firstName = "Unknown", string lastName = "Unknown")
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator string(Person p)
        {
            return p.FirstName + " " + p.LastName;
        }

        public static explicit operator Person(string str)
        {
            string firstName = str.Substring(0, str.IndexOf(' '));
            string lastName = str.Substring(str.IndexOf(' ') + 1);
            return new Person(firstName, lastName);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
