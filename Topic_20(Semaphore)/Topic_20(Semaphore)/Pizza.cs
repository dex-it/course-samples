using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Topic_20_Semaphore_
{
    public class Pizza
    {
        public static int maxOrderingCount = 1; // максимальное колечество пицы, помещяющейся в печку
        Thread thread;
        static Semaphore semaphore = new Semaphore(maxOrderingCount, maxOrderingCount);
        static int countOfOrder = 0;

        public Pizza(int OrderingNumber)
        {
            thread = new Thread(Cooking); // принимаем новый заказ
            thread.Name = OrderingNumber.ToString();
            thread.Start();
            countOfOrder++;
        }

        public void Cooking()
        {
            semaphore.WaitOne();
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Заказ №{Thread.CurrentThread.Name} поступил на кухню");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Заказ №{Thread.CurrentThread.Name} пица в печке");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Заказ №{Thread.CurrentThread.Name} пица готова");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                semaphore.Release();
            }

            countOfOrder--;
            if (countOfOrder == 0)
            {
                Console.WriteLine("Заказов больше нет. Кухня закрылась.");
            }
        }
    }
}