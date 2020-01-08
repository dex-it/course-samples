using System;
using System.Threading;
using System.Collections.Generic;

namespace ActionQueueDemonstration
{
    public class ActionQueue : IJobExecutor
    {
        private object _locker = new object();
        private Thread[] _consumers;
        private Queue<Action> _queue = new Queue<Action>();

        public int Amount => _queue.Count;

        private void Consume()
        {
            while (true) 
            { 
                Action item;
                
                lock (_locker)
                {
                    while (_queue.Count == 0)
                    {
                        Monitor.Wait (_locker);
                    }
                    
                    item = _queue.Dequeue();
                }

                if (item == null)
                {
                    return;
                } 
                
                item(); 
            }
        }
        
        public void Start(int maxConcurrent)
        {
            _consumers = new Thread [maxConcurrent];

            for (var i = 0; i < maxConcurrent; i++)
            {
                _consumers[i] = new Thread(Consume);
                _consumers[i].Start();
            }
        }
        
        public void Stop ()
        {
            foreach (Thread consumer in _consumers)
            {
                Add (null);
                //consumer.Join();
            }
        }

        public void Add (Action item)
        {
            lock (_locker)
            {
                _queue.Enqueue (item);
                Console.WriteLine($"{Thread.CurrentThread.Name}: добавлена задача, (всего: {Amount})");
                Monitor.Pulse (_locker); 
            }
        }

        public void Clear()
        {
            lock (_locker)
            {
                _queue.Clear();
                Console.WriteLine("Очередь очищена");
                Monitor.Pulse (_locker);
            }
        }
    }
}