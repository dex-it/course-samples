using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Dictionary
{
    class Program
    {
        class Person
        {
            public Person(){}
            public Person(int passportID, string firstName, string lastName, DateTime birthDate, string birthPlace)
            {
                PassportID = passportID;
                FirstName = firstName;
                LastName = lastName;
                BirthDate = birthDate;
                BirthPlace = birthPlace;

            }
            public int PassportID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string BirthPlace { get; set; }
            public void ShowInfo()
            {
                Console.WriteLine("PassportId:"+PassportID.ToString()+"\nFirstName:"+FirstName+
                    "\nLastName:"+LastName+"\nBirthDate:"+BirthDate.ToString()+"\nBirthPlace:"+BirthPlace);
            }
        }
        static void Main(string[] args)
        {
            
            Person p1 = new Person(1111, "Иван", "Васильев", Convert.ToDateTime("18.09.1987"), "Тирасполь");
            Person p2 = new Person(2222, "Ксения", "Олейнева", Convert.ToDateTime("11.02.1992"), "Бендеры");
            Person p3 = new Person(3333, "Петр", "Шолохов", Convert.ToDateTime("02.01.1986"), "Тирасполь");
            Person p4 = new Person(4444, "Геннадий", "Серов", Convert.ToDateTime("25.07.1990"), "Слободзея");
            Person p5 = new Person(5555, "Лидия", "Цуканова", Convert.ToDateTime("11.12.1999"), "Тирасполь");
            Dictionary<Person, string> WorkDictionary = new Dictionary<Person, string> { { p1, "Больница" }, { p2, "Школа №2"}, {p3, "Швейная фабрика" } };

            Console.Write("Введите данные для поиска по словарю.\nPassportID:");
            int PassportID = Int32.Parse(Console.ReadLine());
            Console.Write("FirstName:");
            string FirstName = Console.ReadLine();
            Console.Write("LastName:");
            string LastName = Console.ReadLine();
            Console.Write("BirthDate:");
            DateTime BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("BirthPlace:");
            string BirthPlace = Console.ReadLine();
            int k = 0;//для количества записей , соответствующих введенным данным
            foreach (var p in WorkDictionary)
            {
                if (p.Key.PassportID == PassportID && p.Key.FirstName == FirstName && p.Key.LastName == LastName
                    && p.Key.BirthDate == BirthDate && p.Key.BirthPlace == BirthPlace)

                {
                    Console.WriteLine("Work:"+p.Value);
                    k++;
                }
            }
            if(k==0)
                Console.WriteLine("Человек отсутствует в базе данных!");


            Console.ReadKey();

        }
    }
}
