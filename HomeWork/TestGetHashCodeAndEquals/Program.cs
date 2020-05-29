using System;

namespace TestGetHashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(
                "Иванов Иван Иванович",
                new DateTime(1990, 6, 15),
                "Тирасполь",
                111111);

            Person person2 = new Person(
                "Иванов Иван Иванович",
                new DateTime(1990, 6, 15),
                "Тирасполь",
                222222);
            
            Person person3 = new Person(
                "Сидоров Сидр Сидорович",
                new DateTime(1985, 11, 1),
                "Бендеры",
                333333);

            Person person4 = person1;

            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person2.GetHashCode());
            Console.WriteLine(person3.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person3));
            Console.WriteLine(person1.Equals(person4));
            Console.WriteLine(person1.Equals(person1));
            Console.WriteLine();
            Console.WriteLine(person1 == person2);
            Console.WriteLine(person1 == person3);
            Console.WriteLine(person1 == person4);
            Console.WriteLine(person1 == person1);

            Console.ReadLine();
        }
    }
}
