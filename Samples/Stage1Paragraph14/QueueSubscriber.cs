using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph14
{
    public class QueueSubscriber
    {
        public QueueSubscriber(Queue queue)
        {
            queue.QueueIsFull += OnQueueIsFull;
            queue.QueueIsEmpty += OnQueueIsEmpty;
        }

        void OnQueueIsFull()
        {
            Console.WriteLine("Очередь заполнена!");
        }

        void OnQueueIsEmpty()
        {
            Console.WriteLine("Очередь пуста!");
        }
    }
}