using System;

namespace _17_Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            char ch = Console.ReadKey().KeyChar;

            Console.WriteLine();
            Console.WriteLine(name.MakeBorder(ch));
            Console.ReadKey();
        }
    }
    public static class StringExtensions
    {
        private static char _ch { get; set; }
        public static string MakeBorder(this string str, char ch)
        {
            if (str == null || str == "") throw new ArgumentNullException(nameof(str));
            _ch = ch;
            return PrintChar(str.Length+2)+Environment.NewLine+
                   PrintChar(1)+ str+ PrintChar(1) + Environment.NewLine +
                   PrintChar(str.Length + 2);
        }
        private static string PrintChar (int count)
        {
            return new string (_ch, count);
        }
    }
}
