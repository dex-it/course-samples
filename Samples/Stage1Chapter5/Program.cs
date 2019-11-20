using System;

namespace Stage1Chapter5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person discovererOfPluto = new Person("Michael", "Brown");

            string str = "Michael Brown";

            Console.WriteLine("Проверка на эквивалентность c помощью оператора == : " + (str == discovererOfPluto).ToString());

            Console.WriteLine("Проверка на эквивалентность c помощью метода Equals() : " + discovererOfPluto.Equals(str).ToString());

            Console.ReadLine();

        }
    }
}
