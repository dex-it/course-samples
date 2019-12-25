using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace TaskQueueDemonstration
{
    class Program
    {
        private static async void ProduceQueueAsync(TaskQueue queue)
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Run(() => { queue.Add(()=> { Console.WriteLine("Выполнение задачи"); }); });
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            // Создаем очередь
            TaskQueue queue = new TaskQueue();

            // Заполняем очередь
            ProduceQueueAsync(queue);

            // Ожидаем некоторое время
            Thread.Sleep(3000);

            // Запускаем обработку очереди
            int maxConcurrent = 4;
            queue.Start(maxConcurrent);

            // Ожидаем некоторое время
            Thread.Sleep(3000);

            //Останавливаем обработку очереди
            queue.Stop();

            // Ожидаем некоторое время
            Thread.Sleep(10000);

            // Чистим очередь
            queue.Clear();

            Console.ReadLine();
        }
    }
}