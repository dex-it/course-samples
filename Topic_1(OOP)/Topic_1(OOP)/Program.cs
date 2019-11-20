using System;

namespace Topic_1_OOP_
{
	class Program
	{
		static void Main(string[] args)
		{			
			MyCat Tom = new MyCat("Tom");
			Tom.Family = "Felidae";
			Tom.It_is_hungry(4, 2);
			Tom.FeedTheCat();
			Tom.It_is_hungry(1, 2);

			MyDog Lucky = new MyDog("Lucky");
			Lucky.Family = "Canidae";

			ICreatures[] myPets = { Tom, Lucky };
			foreach (var item in myPets)
			{
				Console.WriteLine($"my pets {item.ToString()} = {item.Family}");
			}

			//Console.ReadLine();
		}
	}
}
