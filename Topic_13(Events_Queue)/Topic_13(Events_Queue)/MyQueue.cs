using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Topic_13_Events_Queue_
{
	public class MyQueue : Queue
	{
		Queue<int> myQueue = new Queue<int>();
		private int MaxCount;
		public delegate void MyQueueHandler(string message);
		public event MyQueueHandler QueueEvent;
		public MyQueue(int MaxCount)
		{
			this.MaxCount = MaxCount;
		}
		public void Enqueue(int element)
		{
			if (myQueue.Count < MaxCount)
			{
				myQueue.Enqueue(element);
			}
			else
			{
				QueueEvent?.Invoke($"Достигнуто максимальное количество элементов очереди {myQueue.Count}.");
			}			
		}

		public int Dequeue()
		{
			if (myQueue.Count==0)
			{
				QueueEvent?.Invoke("Очередь пуста!");
			}
			
				return myQueue.Dequeue();

		}

	}
}
