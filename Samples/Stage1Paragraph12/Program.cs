using Stage1Paragraph10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("A", new DateTime(1990, 10, 10), "USA", 1234567);
            Person person2 = new Person( "B", new DateTime(1992, 11, 11), "USA", 1234568);
            Person person3 = new Person ("A", new DateTime(1990, 10, 10), "USA", 1234567);

            Dictionary<Person, bool> personHash = new Dictionary<Person, bool>();
            personHash.Add(person1, true);
            personHash.Add(person2, true);
            personHash.Add(person3, true);
        }
    }
}
