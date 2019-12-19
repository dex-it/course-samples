using System;
using System.Collections.Generic;

namespace list_spravochnik
{
    class Program
    {

      
        static void Main(string[] args)
        {
            Dictionary<Person, string> spravochnik = new Dictionary<Person, string>();
            Person person = new Person();
            /// 
            var per = new Person { FIO = "fio1", Date = 1996, Mesto = "mesto1", Number = 1 };
            spravochnik.Add(per, "mestoraboti 1");
            Console.WriteLine("vvedite:fio1 1996 mesto1 1");
            string zapros = Console.ReadLine();
            var per2 = new Person { FIO = zapros.Split(" ")[0], Date = Convert.ToInt32(zapros.Split(" ")[1]), Mesto = zapros.Split(" ")[2], Number = Convert.ToInt32(zapros.Split(" ")[3]) };
      //      var per3 = new Person { FIO = "fio1", Date = 1996, Mesto = "mesto1", Number = 1 };
            Console.WriteLine("tekushee mestoraboti:" + spravochnik[per2]);
            Console.ReadLine();
        }
        class Person
        {
            public string FIO;
            public int Date;
            public string Mesto;
            public int Number;
           
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (!(obj is Person))
                    return false;
                var person = (Person)obj;
                return person.FIO==FIO&& person.Date == Date && person.Mesto == Mesto && person.Number == Number;
            }
            public override int GetHashCode()
            {
                return (FIO + Date + Mesto + Number).GetHashCode();
            }
          



        }
    }
}
