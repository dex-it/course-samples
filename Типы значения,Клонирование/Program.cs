using System;

namespace Типы_значения_Клонирование
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Tom", Age = 23, Work = new Company { Name = "Microsoft" } };
            Person p2 = (Person)p1.Clone();//клонирование
            p2.Work.Name = "Google";
            p2.Name = "Alice";
            Console.WriteLine(p1.Name); // Tom
            Console.WriteLine(p1.Work.Name); // Microsoft
            Console.Read();
        }
        class Person : ICloneable
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Company Work { get; set; }
            public object Clone()  //метод для создания нового обьекта сисходным значением так как при простого присвоения копируется ссылка
            {Company company = new Company { Name = this.Work.Name }; // создание ссылки на обьект для глубокого копирования
                return new Person { Name = this.Name, Age = this.Age, Work = company };  //поверхосное копирование, кроме Work
             //   return this.MemberwiseClone();   //для упрощения
            }
        }
        class Company
        {
            public string Name { get; set; }
        }
    }
}
