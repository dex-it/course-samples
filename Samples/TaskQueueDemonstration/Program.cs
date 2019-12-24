using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskQueueDemonstration
{
    internal class Program
    {
        private static void ProduceQueue(TaskQueue queue)
        {
            for (int i = 0; i < 100; i++)
            {
                queue.Add(() =>
                {
                    Console.WriteLine($"Выполнение задачи");
                    Thread.Sleep(TimeSpan.FromSeconds(0.5));
                });

                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

        private static async void ProduceQueueAsync(TaskQueue queue)
        {
            await Task.Run(() => ProduceQueue(queue));
        }

        public static void Main(string[] args)
        {
            // Создаем очередь задач
            TaskQueue queue = new TaskQueue();

            // Добавляем асинхронно задачи в очередь
            ProduceQueueAsync(queue);
            
            // Запускаем обработку очереди c заданным числом одновременно выполняемых задач
            int maxConcurrent = 4;
            queue.Start(maxConcurrent);

            // Ожидаем некоторое время
            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Останавливаем обработку очереди
            queue.Stop();

            // Ожидаем некоторое время
            Thread.Sleep(TimeSpan.FromSeconds(3));

            // Очищаем очередь
            queue.Clear();

            Console.ReadLine();

        }
    }
}