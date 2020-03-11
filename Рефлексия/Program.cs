using System;
using System.Linq;
using System.Reflection;

namespace Рефлексия
{
    public class User
    {
        private int type = 10;
        private int type2 = 15;
        public string Name_peaple { get; set; }
       private string Name_peaple2 { get; set; } 


        public int Age { get; set; }
        public User(string n, int a)
        {
            Name_peaple = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name_peaple}  Возраст: {Age}");
        }
        public int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
        class Program
        {
            public static string PrintObjectProperties(object ob) //Рефлексия
            {
                if (ob == null) throw new ArgumentNullException(nameof(ob));
                var get_type = ob.GetType(); // получаем тип   
                Console.WriteLine("Обьект: " + get_type);
                var get_properties = get_type.GetProperties(BindingFlags.Public | BindingFlags.Instance ); //  получаем все свойства, не статические (noтpublick на приваченные)        
                var values_properties = get_properties.Select(x => $"{x.Name} : {x.GetValue(ob)}"); // перебираем все  свойства и описываем формат сохранения в строку

                var get_fields = get_type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance); //получаем все не публичные поля
                var values_fields = get_fields.Select(x => $"{x.Name} : {x.GetValue(ob)}");

                var get_methods = get_type.GetMethods(); //получение методов
                var values_methods = get_methods.Select(x => $"{x.Name} -тип метода> {x.ReturnType.Name}");

                var get_constructors = get_type.GetConstructors(); //получение конструкторов
                var values_constructors = get_constructors.Select(x => $" \n {x.Name} - параметры: {string.Join(",", x.GetParameters().Select(y=>$"{y.ParameterType.Name}-{y.Name}"))}");

                return "Cвойства: "+string.Join(", \n", values_properties)+"\n Поля: "+ string.Join(", \n", values_fields)+"\n Методы: " + string.Join(", \n", values_methods) + "\n Конструкторы: " + string.Join(", \n", values_constructors); // формируем строку

          }
            static void Main(string[] args)
            {
                User user = new User("Cерафим",11);
                Console.WriteLine(PrintObjectProperties(user));          
              
                Console.ReadLine();
            }
        }
    }
}
