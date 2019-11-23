using System;
using System.Globalization;

namespace Stage1Chapter5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person discovererOfPluto = new Person("Michael", "Brown");

            string str = "Michael Brown";

            Console.WriteLine("Проверка на эквивалентность c помощью оператора == : " + (str == discovererOfPluto).ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Проверка на эквивалентность c помощью метода Equals() : " + discovererOfPluto.Equals(str).ToString(CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
