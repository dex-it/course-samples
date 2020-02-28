using System;

namespace Неявное__Явное_преобразование
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и фамилию в строку через пробел");
            string str = Console.ReadLine();

            Person1 person1 = new Person1();
            Person2 person2 = new Person2();

            // не явное преобразование
            person1 = str; 
            string s1 = person1;

            //явное преобразование
            person2 = (Person2)str; 
            string s2 = (string)person2; 


            Console.WriteLine("Строка не явного преобразования: "+s1 +"\n "+ (s1 == person1)+" " + s1.Equals(person1).ToString() + " "+person1.Equals(s1).ToString());
            Console.WriteLine();
            Console.WriteLine("Строка не явного преобразования: "+s2 + "\n " + s2.Equals(person2).ToString() + " " + person2.Equals(s2).ToString());
  
            Console.ReadLine();
          //  var sr1 = (str == Person)?true:false;
        }       
    }
    class Person1
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       
        //конструкция не явного преобразования
        public static implicit operator Person1(string s)
        {
            return new Person1() { FirstName = s.Split(" ")[0], LastName = s.Split(" ")[1] };
        }     
        public static implicit operator string(Person1 p2) 
        {
            return p2.FirstName.ToString() + " " + p2.LastName.ToString();
        }
    }
    class Person2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //конструкция явного преобразования
        public static explicit operator Person2(string s)  
        {
            return new Person2() { FirstName = s.Split(" ")[0], LastName = s.Split(" ")[1] };
        }
        public static explicit operator string(Person2 p2) 
        {
            return p2.FirstName.ToString() + " " + p2.LastName.ToString();
        }
    }
}
