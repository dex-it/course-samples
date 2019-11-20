using System;

namespace Topic_4_Downcasting_Example_Person_
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person { FirstName = "Антон", LastName = "Перов" };
			Console.WriteLine("До присвоения");
			Console.WriteLine($"{person.FirstName} {person.LastName}");
			person = (Person)"Семен";
			Console.WriteLine("После присвоения");
			Console.WriteLine($"{person.FirstName} {person.LastName}");
		}
	}
}
