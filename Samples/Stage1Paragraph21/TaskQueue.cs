using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Stage1Paragraph21
{
    public class TaskQueue : IJobExecutor
    {
        private BlockingCollection<Action> queue;
        private Task[] parallelTasks;
        
        public int Amount => queue.Count;

        public TaskQueue()
        {
            queue = new BlockingCollection<Action>();
        }
        
        public void Start(int maxConcurrent)
        {
            parallelTasks = new Task[maxConcurrent];

            for (int i = 0; i < maxConcurrent; i++)
            {
                parallelTasks[i] = new Task(queue.Take());
            }
        }

        public void Stop()
        {
            foreach (var task in parallelTasks)
            {
                task.Start();
            }
        }

        public void Add(Action action)
        {
            queue.Add(action);
        }

        public void Clear()
        {
            // первый вариант
            queue = new BlockingCollection<Action>();
            
            // второй вариант
            //while (queue.Count > 0)
            //{
            //    queue.Take();
            //}
        }
    }
}