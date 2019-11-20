using System;

namespace Topic_14_Exception_
{
	class Program
	{
		static void Main(string[] args)
		{
			Counter();
			Console.WriteLine("Countr is finish");
			Console.Read();
		}

		public static void Counter()
		{
			int i = 0;
			while (i<100)
			{
				try
				{
					i++;
					if (i > 25)
					{
						throw new Exception("i  превысил 25");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine($"Пепрехвачено исключение {e}");
					break;
				}
				finally
				{
					Console.WriteLine("Выполняеться блок finally");
				}
				
			}
		}
	}
}
