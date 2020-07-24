using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20_RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Выделить числа из текста");
            Console.WriteLine("2 - Выделить параметры из строки запроса");
            Console.WriteLine("3 - Удалить из выражения повторяющиеся пробелы");
            Console.WriteLine("4 - Проверить что вводимое число - корректный номер телефонаа");
            

            ConsoleKeyInfo keyInfo;
            while (isWorking) 
            {
                int code;
                if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out code))
                {
                    Console.Write("\b \b");
                }

                isWorking = false;
                switch (code)
                {
                    case 1:
                        GetNumbersFromText();
                        break;
                    case 2:
                        GetParametersFromURL();
                        break;
                    case 3:
                        RemoveDuplicateSpaces();
                        break;
                    case 4:
                        IsCorrectPhoneNumber();
                        break;
                    default:
                        isWorking = true;
                        break;
                }
            }

            Console.WriteLine();
            CloseProgramEsc();
        }

        private static void GetNumbersFromText()
        {
            string line = Console.ReadLine();
            string pattern = "";
            MatchCollection match = Regex.Matches(line, pattern);

            
        }

        private static void GetParametersFromURL()
        {
            
        }
        private static void RemoveDuplicateSpaces()
        {
            
        }
        private static void IsCorrectPhoneNumber()
        {
            
        }

        private static void CloseProgramEsc()
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.WriteLine("Для выхода нажмите Esc");
                btn = Console.ReadKey(true);
            } while (btn.Key != ConsoleKey.Escape);
        }
    }
}
