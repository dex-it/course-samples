using System;

namespace TypeCastingAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            string name = "Пушкин Александр";
            string name2 = "Пушкин Александр Сергеевич";
            person = name;
            WriteConsole (person.FirstName, person.LastName);
            person = name2;
            WriteConsole(person.FirstName, person.LastName);

            FIO fio = new FIO ( "Лев", "Николаевич", "Толстой" );
            person = (Person)fio;
            WriteConsole(person.FirstName, person.LastName);

            Console.WriteLine((string)person);

        }
        public static void WriteConsole(string firstName, string lastName)
        {
            Console.WriteLine("Имя: {0} Фамилия: {1}", firstName, lastName);
        }
    }
}
