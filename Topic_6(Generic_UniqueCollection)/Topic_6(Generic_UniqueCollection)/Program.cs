using System;

namespace Topic_6_Generic_UniqueCollection_
{
	class Program
	{
		static void Main(string[] args)
		{
			var uniqueCollection = new UniqueCollection<string>();
			string userElement = " ";

			while (userElement != "`")
			{
				Console.WriteLine("Введите новый элепент коллекции:");
				userElement = Console.ReadLine();

				try
				{
					uniqueCollection.AddElement(userElement);
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
