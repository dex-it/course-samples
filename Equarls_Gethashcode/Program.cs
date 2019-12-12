using System;

namespace Equarls_Gethashcode
{
    class Program
    {
        static void Main(string[] args)
        {

           Person p1 = new Person { fio = "f1", date =DateTime.Today, mesto_rozhdeniya="d4", number=5 };
           Person p2 = new Person { fio = "f1", date = DateTime.Today, mesto_rozhdeniya = "d4", number = 5 };
           Person p3 = new Person { fio = "f2", date = DateTime.Today, mesto_rozhdeniya = "d4", number = 6 };

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string fio { get; set; }
        public DateTime date { get; set; }
        public string mesto_rozhdeniya { get; set; }
        public int number { get; set; }

      
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Person))
                return false;
            var pr = (Person)obj;

            return pr.fio == fio && pr.date == date && pr.mesto_rozhdeniya == mesto_rozhdeniya && pr.number == number;
        }
        public override int GetHashCode()
        {
            return (fio + date.ToString() + mesto_rozhdeniya + number.ToString()).GetHashCode();
        }
}


 }
