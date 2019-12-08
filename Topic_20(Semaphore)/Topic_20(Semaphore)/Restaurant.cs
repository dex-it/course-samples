using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Topic_20_Semaphore_
{
    public class Restaurant
	{
        public static int maxOrderingCount = 1; /// максимальное колечество пицы, помещяющейся в печку
        Thread thread;
        public Semaphore semaphore = new Semaphore(maxOrderingCount, maxOrderingCount);//
        int countOfOrder = 0;//


		public void MakeAnOrder(int OrderingNumber)
		{
			countOfOrder++;
			thread = new Thread(Cooking); // принимаем новый заказ
			thread.Name = OrderingNumber.ToString();
			thread.Start();
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