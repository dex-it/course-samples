using System;

namespace Неявное__Явное_преобразование
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и фамилию в строку через пробел");
            string str = Console.ReadLine();
            Person person = new Person { FirstName = str.Split(' ')[0], LastName = str.Split(' ')[1]};

          //  var sr1 = (str == Person)?true:false;
        }
    }
    class Person
    {
       public string FirstName { get; set; }
      public string LastName { get; set; }

      
    }
}
