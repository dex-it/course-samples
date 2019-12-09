using System;

namespace Topic_18_MySerializer_
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person
			{
				Name = "Byll",
				Surname = "Jonson",
				Patronymic = "Иванович"
			};

			MySerializer mySerializer = new MySerializer();
		
			foreach (var item in mySerializer.Serialize(person))
			{
				Console.WriteLine($"Listt - {item}");
			}

			// Person p =(Person)mySerializer.Deserializer<Person>(mySerializer.Serialize2(person));
			mySerializer.Deserializer<Person>(mySerializer.Serialize2(person));
		}
	}
}
