using System;

namespace Topic_1_OOP_
{
	class Program
	{
		static void Main(string[] args)
		{			
			MyCat tom = new MyCat("Tom");
			tom.Family = "Felidae";
			tom.ItIsHungry(4, 2);
			tom.FeedTheCat();
			tom.ItIsHungry(1, 2);
			tom.ChangeCountOfLegs(5);

			MyDog lucky = new MyDog("Lucky");
			lucky.Family = "Canidae";

			ICreature[] myPets = { tom, lucky };
			foreach (var item in myPets)
			{
				Console.WriteLine($"my pets {item.ToString()} = {item.Family}");
			}

			//Console.ReadLine();
		}
	}
}
