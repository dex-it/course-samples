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

			string serData = mySerializer.Serialize(person);
			Console.WriteLine($"serData = {serData} ");

			Person person2 = mySerializer.Deserializer<Person>(serData);
			Console.WriteLine($"\nDeserialise data: \nName = {person2.Name} \nSurname = {person2.Surname} \nPatronymic = {person2.Patronymic} ");
		}
	}
}
