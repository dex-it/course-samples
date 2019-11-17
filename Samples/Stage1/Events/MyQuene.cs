using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Stage1.Events
{
    //реализовать очередь которая генерирует событие
    //когда кол-во объектов в ней превышает n и событие когда становится пустой   

    public class MyQuene<T>
    {
        public event EventHandler Full;
        public event EventHandler Empty;

        private Queue<T> _queue;

        private int MaxCount { get; set; }

        public MyQuene(int maxCount)
        {
            MaxCount = maxCount;
            _queue = new Queue<T>();
        }

        public void Add(T item)
        {
            try
            {
                if (_queue.Count == MaxCount)
                {
                    Full?.Invoke(this, EventArgs.Empty);
                    return;
                }

                _queue.Enqueue(item);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool Dequeue()
        {
            if (_queue.Count == 0)
            {
                Empty?.Invoke(this, EventArgs.Empty);
                return false;
            }

            _queue.Dequeue();
            
            return true;
        }
    }

    public class Test
    {
        [Test]
        public void MyQueneTest()
        {
            var myQuene = new MyQuene<string>(3);
          
            EventHandler queneIsFull=delegate { Console.WriteLine("Quene is Full"); };
            EventHandler queneIsEmpty=delegate { Console.WriteLine("Quene is Empty"); };

            myQuene.Full += queneIsFull;

            myQuene.Empty += queneIsEmpty;

            for (int i = 0; i < 4; i++)
            {
                myQuene.Add("Item " + i);
            }

            while (myQuene.Dequeue())
            {
                myQuene.Dequeue();
            }

            myQuene.Full -= queneIsFull;
            myQuene.Empty -= queneIsEmpty;
            

        }

    }
}