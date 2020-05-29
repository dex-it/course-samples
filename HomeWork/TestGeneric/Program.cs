using System;

namespace TestUniqueCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            UniqueCollection<Person> uniqueCollection = new UniqueCollection<Person>();

            Console.WriteLine("Добавьте 3 уникальные персоны");

            while (i < 3)
            {
                try
                {
                    Console.WriteLine();
                    uniqueCollection.Add(EntireRequest());
                    i++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
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
