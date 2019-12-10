using System;
using System.Threading;

namespace Topic_20_Semaphore_
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int CountOfOrdering = 5; //задаем текущее количество заказов
			var restaurant = new Restaurant();

			for (int i = 1; i < CountOfOrdering+1; i++)
			{				
				Thread.Sleep(50);
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine($"_ _ _ Принят заказ №{i}_ _");
				restaurant.MakeAnOrder(i); 		
			}
		}
	}
}
