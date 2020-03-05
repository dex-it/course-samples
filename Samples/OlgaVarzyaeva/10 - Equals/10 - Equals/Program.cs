using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Equals
{
    class Person
    {
        public int PassportID { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }

        public override bool Equals(object obj)
        {
            if (obj!=null)
            {
                if (obj is Person)
                {
                    var person = (Person)obj;
                    return person.PassportID == PassportID
                        && person.FirstName == FirstName
                        && person.LastName == LastName
                        && person.BirthDate == BirthDate
                        && person.BirthPlace == BirthPlace;
                }
                else return false;

            }
            else return false;
        }
        public override int GetHashCode() //доделать
        {
            return (PassportID + FirstName.GetHashCode())%(LastName.GetHashCode()+BirthDate.GetHashCode()+BirthPlace.GetHashCode());
        }
        
}
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.FirstName = "Мария";
            p1.LastName = "Иванова";
            p1.PassportID= 15825;
            p1.BirthDate = Convert.ToDateTime("18.05.2010");
            p1.BirthPlace = "Первомайск";
            Person p2 = new Person();
            p2.FirstName = "Мария";
            p2.LastName = "Иванова";
            p2.PassportID = 15825;
            p2.BirthDate = Convert.ToDateTime("18.07.2010");
            p2.BirthPlace = "Первомайск";
            Console.WriteLine("Equals:"+p1.Equals(p2));
            Console.WriteLine("GetHashCode:p1=" + p1.GetHashCode()+", p2="+p2.GetHashCode());
            Console.ReadLine();
        }
    }
}
