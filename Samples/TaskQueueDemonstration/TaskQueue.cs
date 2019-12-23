﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace TaskQueueDemonstration
{
    public class TaskQueue : IJobExecutor
    {
        private BlockingCollection<Action> _queue;
        private CancellationTokenSource _cancelTokenSource;
        private CancellationToken _token;
        
        public int Amount => _queue.Count;

        public TaskQueue()
        {
            _queue = new BlockingCollection<Action>();
            _cancelTokenSource = new CancellationTokenSource();
            _token = _cancelTokenSource.Token;
            
            Console.WriteLine($"Создана очередь, количество задач: {Amount}");
        }
        
        public void Start(int maxConcurrent)
        {
            for (var i = 0; i < maxConcurrent; i++)
            {
                Task.Factory.StartNew(Consume);
            }
        }

        private void Consume()
        {
            foreach (var action in _queue.GetConsumingEnumerable())
            {
                if (_token.IsCancellationRequested)
                {
                    return;
                }
                
                action();
            }
        }

        public void Stop()
        {
            _cancelTokenSource.Cancel(); 
        }

        public void Add(Action action)
        {
            _queue.Add(action);

            Console.WriteLine($"Добавлена задача, количество задач: {Amount}");
        }

        public void Clear()
        {
            // первый вариант
            _queue = new BlockingCollection<Action>();
            
            // второй вариант
            //while (queue.Count > 0)
            //{
            //    queue.Take();
            //}
        }
    }
}