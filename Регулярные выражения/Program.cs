using System;
using System.Text.RegularExpressions;

namespace Регулярные_выражения
{
    class Program
    {
        static void Main(string[] args)
        {
            // выделить числа из текста(1, 1000, 1 000 000, 100.23)
            string str = "1, 1000, 1 000 000, 100.23";
           Regex regex = new Regex(@"(\d{1,3}\s(\d{3}\s?)*)|(\d+\.\d+)|\d+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }

           // удалить из выражения повторяющиеся пробелы, между токенами д.б. 1 пробел
            string s = "Мама  мыла  раму. ";
            string pattern = @"\s+";
            string target = " ";
            regex = new Regex(pattern);
            string result = regex.Replace(s, target);
            Console.WriteLine(s);


            //  проверить что вводимое число -корректный номер телефона(+373 77767852, 77767852, 0 (777) 67852)
            Console.WriteLine("Введите номер телефона");
            string number = Console.ReadLine();
           string reg =@"(\+\d{3}\s\d{8})|(0\s\(\d{3}\)\s\d{5})|\d{8}";
          
                if (Regex.IsMatch(number, reg))
                     Console.WriteLine(" Номер:{0}-Существующий номер", number);
                else
                     Console.WriteLine("Номер: {0}-Ошибочный номер", number);
                Console.ReadLine();


        }
    }
}
