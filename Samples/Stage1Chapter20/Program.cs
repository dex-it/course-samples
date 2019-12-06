using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter20
{
    class Program
    {
        static void Main()
        {
            RegularExpression regExp = new RegularExpression();

            // 1 
            Console.WriteLine("Введите адрес электронной почты");
            string email = Console.ReadLine();

            regExp.IsEmailInfo( regExp.IsEmail(email) );

            // 2
            string numberExp = "(1, 1000, 1 000 000, 100.23)";
            List<string> listNumExp = regExp.NumberExpression(numberExp);
            foreach (var s in listNumExp)
            {
                Console.WriteLine($"Число: {s}");
            }
            Console.ReadLine();
        }
    }
}
