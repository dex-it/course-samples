using System;
using System.Linq;
using System.Reflection;

namespace Рефлексия
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
        public int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
        class Program
        {
            public static string PrintObjectProperties(object target)
            {
                if (target == null) throw new ArgumentNullException(nameof(target));
                var type = target.GetType(); // получаем тип
                Console.WriteLine(type);
                var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance); //                получаем все публичные свойства, не статические
                Console.WriteLine(props);
                var values = props.Select(x => $"{x.Name} : {x.GetValue(target)}"); // перебираем все                свойства и описываем формат сохранения в строку
                return string.Join(", ", values); // формируем строку



                
//GetFields(BindingFlags)
//GetProperties(BindingFlags)
//GetMethods(BindingFlags)
//GetConstructors(BindingFlags)

//            }
            static void Main(string[] args)
            {
                User user = new User("11",1);
                Console.WriteLine(PrintObjectProperties(user));
           
              
                Console.ReadLine();
            }
        }
    }
}
