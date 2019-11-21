using Stage1Paragraph10;
using System;
using System.Collections.Generic;

namespace Stage1Paragraph11
{
    class Program
    {

        private static void FillJobSprav(Dictionary<Person, string> sprav)
        {
            // Заполняем словарь
            sprav[new Person("Николай", new DateTime(1970, 01, 01), "Москва", 1111111)] = "Рога и копыта";
            sprav[new Person("Анатолий", new DateTime(1975, 01, 01), "Таганрог", 3333333)] = "Ресторан Плакучая ива";
            sprav[new Person("Джорж", new DateTime(1985, 01, 01), "Техас", 2222222)] = "Голивуд";
            sprav[new Person("Сергей", new DateTime(1990, 01, 01), "Тирасполь", 9999999)] = "Шериф";
            sprav[new Person("Александр", new DateTime(1992, 01, 01), "Москва", 5555555)] = "Microsoft";
            sprav[new Person("Григорий", new DateTime(1978, 01, 01), "Новосибирск", 4444444)] = "Газпром";
            sprav[new Person("Санду", new DateTime(1960, 01, 01), "Кишинев", 7777777)] = "Orange";
            sprav[new Person("Тарас", new DateTime(1988, 01, 01), "Киев", 88888888)] = "конфетная фабрика Рошен";
        }

        private static void FindPlaceOfJob(Dictionary<Person, string> sprav, Person person)
        {
            foreach (var personPair in sprav)
            {
                if (personPair.Key == person)
                {
                    Console.WriteLine($"Искомое место работы: {personPair.Value}");
                    return;
                }
            }

            Console.WriteLine("Место работы не найдено!");
        }

        static void Main()
        {
            // заполняем справочник
            var jobSprav = new  Dictionary<Person, string>();
            FillJobSprav(jobSprav);

            // ищем место работы
            var sourcePerson = new Person("Григорий", new DateTime(1978, 01, 01), "Новосибирск", 4444444);
            FindPlaceOfJob(jobSprav, sourcePerson);

            sourcePerson = new Person("Григорий", new DateTime(1978, 01, 01), "Новосибирск", 0000000);
            FindPlaceOfJob(jobSprav, sourcePerson);

            // Вопрос: Как правильно обработать в этом случае ошибочную ситуацию, если будет sourcePerson = null ?

            Console.ReadLine();
        }
    }
}
