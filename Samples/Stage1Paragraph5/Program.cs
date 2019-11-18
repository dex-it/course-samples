using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person("Григорий", "Сидоров");
            string strMan = man;

            Console.WriteLine($"Исходный объект: {man.FirstName} {man.LastName}");
            Console.WriteLine($"Неявно преобразованый объект в строку: {strMan}");
            Console.WriteLine($"Преобразование используя метод ToString() {man.ToString()}");

            string strWoman = "Мария Петрова";
            Person woman = (Person)strWoman;

            Console.WriteLine($"\nИсходная строка: {strWoman}");
            Console.WriteLine($"Явно преобразованная строка в объект: {woman.FirstName} {woman.LastName}");

            Console.WriteLine("Сравнение с помощью оператора ==");
            Console.WriteLine(man == strMan);


            Console.WriteLine("\nСравнение с помощью Equals()");
            Console.WriteLine(woman.Equals(strWoman));

            Console.ReadLine();
        }
    }
}
