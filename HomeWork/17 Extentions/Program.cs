using System;

namespace _17_Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                string numbers = "";
                ConsoleKeyInfo btn;
                Console.WriteLine("Введите число и нажмите Enter. Для выхода нажмите Esc");
                do
                {
                    int parse;
                    btn = Console.ReadKey(true);
                    if (btn.Key == ConsoleKey.Enter)
                    {
                        break;
                    }else if (btn.Key == ConsoleKey.Backspace)
                    {
                        if (!String.IsNullOrEmpty(numbers))
                            numbers = numbers.Remove(numbers.Length - 1);
                        Console.Write("\b \b");
                    }
                    else
                    {
                        if (Char.IsDigit(btn.KeyChar))
                        {
                            numbers += btn.KeyChar.ToString();
                            Console.Write(btn.KeyChar);
                        }
                    }
                } while (btn.Key != ConsoleKey.Escape);

                if (btn.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    int seconds;
                    if (int.TryParse(numbers, out seconds))
                    {
                        Console.WriteLine(Environment.NewLine + seconds.Seconds());
                    }
                }
            } 
        }

    }
}
