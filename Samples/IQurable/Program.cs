using System;
using System.Linq;

namespace IQurable
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int длина_произвольной_строки;
            int id_символа;
            string формирующая_строка;
            int выбор;


            //  DateTime date1 = new DateTime(9210, 12, 12, 12, 24, 24);

            //  //getting a 64 - bit signed integer
            //  // using ToBinary() method
            //long binLocal = date1.ToBinary();
            //  Console.WriteLine(binLocal.ToString());



            Произвольный_тип[] пз = new Произвольный_тип[100];

            for (int i = 0; i < 100; i++)
            {
                формирующая_строка = "";
                длина_произвольной_строки = random.Next(1,10);
                for (int j = 0; j < длина_произвольной_строки; j++)
                    формирующая_строка += (char)(random.Next(65, 91));
                выбор = random.Next(2);
                пз[i] = new Произвольный_тип { Строка = формирующая_строка, Число = random.Next(100), Дата = DateTime.FromBinary((long)(random.Next(100000000, 999999999)* (long)random.Next(100000000, 999999999))), Истина_ложь = (выбор == 1) ? true : false };
                    Console.WriteLine("id: "+i+"     | \""+ пз[i].Строка.ToString()+"\" | "+ пз[i].Число.ToString() + " | " + пз[i].Дата.ToString() + " | " + пз[i].Истина_ложь.ToString());

            }

            Console.WriteLine("\n Выбрать обьекты где число больше 50 и сортировать по строкам \n ");
            var запрос_фильтрации_и_сортировки =  пз.Where(t => t.Число>50).OrderBy(t => t.Строка);
            foreach (Произвольный_тип s in запрос_фильтрации_и_сортировки)
                Console.WriteLine("Выбрано: " + s.Строка.ToString() + "\" | " + s.Число.ToString() + " | " + s.Дата.ToString() + " | " + s.Истина_ложь.ToString());


            Console.WriteLine("\n Группировка истина,ложь \n ");
            var true_false = from i in пз
                               group i by i.Истина_ложь into g
                               select new
                               {
                                   выбор = g.Key,
                                   Count = g.Count(),
                                   вывод = from с in g select с
                                   
                               };
            foreach (var group in true_false)
            {
                Console.WriteLine($"{group.выбор} : {group.Count}");
                foreach (Произвольный_тип пзт in group.вывод)
                    Console.WriteLine("Выбрано: " + пзт.Строка.ToString() + "\" | " + пзт.Число.ToString() + " | " + пзт.Дата.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("\n Есть ли число 30? \n ");
            if (пз.Any(u => u.Число == 30))
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");

            Console.WriteLine("\n Все коллекции истинны? \n ");
            if (пз.All(u => u.Истина_ложь==true))
                Console.WriteLine("да");
            else
                Console.WriteLine("нет");


            Console.WriteLine("\n Cумма чисел="+пз.Sum(i=>i.Число) +", Миниум"+пз.Min(i => i.Число) + ", Максиум"+ пз.Max(i => i.Число )+ " \n ");
       

        }
    }

    class Произвольный_тип
    {
        public string Строка { get; set; }
        public int Число { get; set; }
        public DateTime Дата { get; set; }
        public bool Истина_ложь { get; set; }

    }
}
