using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace TaskQueueDemonstration
{
    internal class TaskQueue : IJobExecutor
    {
        private BlockingCollection<Action> queue = new BlockingCollection<Action>();
        private static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        private CancellationToken token = cancelTokenSource.Token;

        public int Amount => queue.Count;

        private void Consume(int taskNumber)
        {
            Action action;
            while (!token.IsCancellationRequested)
            {
                action = queue.Take();
                action();
            }            
        }

        public async void StartAsync(int taskNumber)
        {
            await Task.Run(() => Consume(taskNumber));            
        }

        public void Start(int maxConcurrent)
        {
            for (var i = 0; i < maxConcurrent; i++)
            {
                StartAsync(i);
            }            
        }

        public void Stop()
        {
            cancelTokenSource.Cancel();            
        }

        public void Add(Action action)
        {
            queue.Add(action);

            Console.WriteLine($"Добавлена задача. Количество задач: {Amount}");            
        }

        public void Clear()
        {
            queue = new BlockingCollection<Action>();

            Console.WriteLine("Очередь очищена");
        }        
    }
}
