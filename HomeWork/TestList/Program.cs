using System;
using System.Collections.Generic;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(
                "Иванов Иван Иванович",
                new DateTime(1990, 6, 15),
                "Тирасполь",
                "111111");

            Person person2 = new Person(
                "Иванов Иван Иванович",
                new DateTime(1990, 6, 15),
                "Тирасполь",
                "222222");

            Person person3 = new Person(
                "Сидоров Сидр Сидорович",
                new DateTime(1985, 11, 1),
                "Бендеры",
                "333333");
            
            Person person4 = new Person(
                "1",
                new DateTime(2001, 1, 1),
                "1",
                "1");

            Dictionary<Person, string> spravMestoRaboti = new Dictionary<Person, string>
            {
                {person1,"Шериф"},
                {person2,"Квинт"},
                {person3,"Тираэт"},
                {person4,"Тиратекс"}
            };

            foreach (var pair in spravMestoRaboti)
                Console.WriteLine("{0} - {1}", pair.Key.ToString(), pair.Value);
            Console.WriteLine();

            string mestoraboti;
            spravMestoRaboti.TryGetValue(EntireRequest(), out mestoraboti);
            if (mestoraboti != null)
                Console.WriteLine(mestoraboti);
            else
                Console.WriteLine("Такого человека нет в базе");
        }

        public static Person EntireRequest()
        {
            Console.WriteLine("Введите ФИО");
            string fio = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            DateTime dataRogdenia = new DateTime();
            while (dataRogdenia == DateTime.MinValue)
            {
                if (!DateTime.TryParse(Console.ReadLine(), out dataRogdenia))
                {
                    Console.WriteLine("Некорректная дата рождения. Повторите ввод");
                }
            }
            Console.WriteLine("Введите место рождения");
            string mestoRogdenia = Console.ReadLine();
            Console.WriteLine("Введите номер паспорта");
            string nomPasporta = Console.ReadLine();

            return new Person(fio, dataRogdenia, mestoRogdenia, nomPasporta);
        }
    }
}
