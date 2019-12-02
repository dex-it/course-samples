using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Paragraph14
{
    public delegate void Handler();

    public class Queue
    {
        List<int> list = new List<int>();

        public int MaxValue { get; set; }

        public event Handler QueueIsFull;
        public event Handler QueueIsEmpty;

        public void Enqueue(int value)
        {
            list.Add(value);

            if (list.Count == MaxValue)
            {
                QueueIsFull();
            }
        }

        public int Dequeue()
        {
            var result = list[0];
            list.RemoveAt(0);

            if (list.Count == 0)
            {
                QueueIsEmpty();
            }

            return result;
        }
    }
}