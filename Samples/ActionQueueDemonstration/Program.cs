using System;
using System.Threading;

namespace ActionQueueDemonstration
{
    internal class Program
    {
        private static void FillQueue(ActionQueue queue)
        {
            for (int i = 0; i < 20; i++)
            {
                queue.Add(() =>
                {
                    Console.WriteLine("Выполнение задачи");
                });
                Thread.Sleep(1000);
            }
        }
        
        public static void Main()
        {
            // Создаем очередь
            ActionQueue queue = new ActionQueue();
            
            // Добавляем в очередь задачи из разных потоков
            Thread t1 = new Thread(() => FillQueue(queue));
            t1.Name = "Поставщик 1";
            t1.Start();

            Thread t2 = new Thread(() => FillQueue(queue));
            t2.Name = "Поставщик 2";
            t2.Start();

            Thread t3 = new Thread(() => FillQueue(queue));
            t3.Name = "Поставщик 3";
            t3.Start();
            
            // Ожидаем некоторое время
            Thread.Sleep(3000);
            
            // Запускаем обработку очереди
            queue.Start(2);
            
            // Ожидаем некоторое время
            Thread.Sleep(3000);
            
            // Останавливаем обработку очереди
            queue.Stop();
            
            // Ожидаем некоторое время
            Thread.Sleep(5000);
            
            // Чистим очередь
            queue.Clear();

            Console.ReadLine();
        }
    }
}