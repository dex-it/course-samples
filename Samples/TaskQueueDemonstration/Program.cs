using System;
using System.Threading;

namespace TaskQueueDemonstration
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // создание очереди задач
            TaskQueue queue = new TaskQueue();
            
            // Добавление элемента в очередь
            for (int i = 0; i < 10; i++)
            {
                queue.Add(() => Console.WriteLine($"Задача{i}"));
                Thread.Sleep(TimeSpan.FromSeconds(10));
            }
        }
    }
}