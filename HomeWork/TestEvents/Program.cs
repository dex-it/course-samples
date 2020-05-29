using System;

namespace TestEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            Random rnd = new Random();

            line.SpecialEvent += Line_SpecialEvent;

            Console.WriteLine("Введите порог очереди");
            int threshold;
            while (!int.TryParse(Console.ReadLine(), out threshold))
            {
                Console.WriteLine("Вы ввели неверное число");
            }
            line.SetThreshold(threshold);

            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Добавить - A; Удалить - D; Выход - Esc");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.A)
                {
                    line.AddNewLineMember(rnd.Next(1,9));
                }
                if (key.Key == ConsoleKey.D)
                {
                    line.RemoveLineMember();
                }
            }
            while (key.Key != ConsoleKey.Escape);

            line.Dispose();
        }

        private static void Line_SpecialEvent(object sender, SpecialEventArgs e)
        {
            Console.WriteLine("Событие: {0}. Количество участников очереди = {1}",
                e.Message, e.CountOfMembers);
        }
    }
}
