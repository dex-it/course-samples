using System;

namespace Topic_6_Generic_UniqueCollection_
{
	class Program
	{
		static void Main(string[] args)
		{
			UniqueCollection<string> uniqueCollection = new UniqueCollection<string>();			
			
			while (true)
			{
				Console.WriteLine("Введите новый элепент коллекции:");
				string UserElement = Console.ReadLine();
				try
				{
					uniqueCollection.AddElement(UserElement);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally
				{
					foreach (var item in uniqueCollection.GetCollection)
					{
						Console.WriteLine(item);
					}

					Console.WriteLine("___________________ -");
				}


			}

		}
	}
}
