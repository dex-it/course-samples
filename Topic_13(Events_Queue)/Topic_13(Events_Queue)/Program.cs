using System;
using System.Collections.Generic;
using System.Threading;

namespace Topic_13_Events_Queue_
{
	class Program
	{
		static void Main(string[] args)
		{

			var myQueue = new MyQueue(9);
			myQueue.QueueEvent += Handler;
			int number;

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine($"i = {i}");				
				myQueue.Enqueue(i);
				Thread.Sleep(500);
			}

			try
			{
				for (int i = 10; i > 0; i--)
				{
					Console.WriteLine($"i = {i}");
					number = myQueue.Dequeue();
					Console.WriteLine($"number = {number}");
					Thread.Sleep(500);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		
			
		}
		public static void Handler(string message)
		{
			Console.WriteLine(message);
		}
	}
}
