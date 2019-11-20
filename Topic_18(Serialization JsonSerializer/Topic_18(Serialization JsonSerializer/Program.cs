using Newtonsoft.Json;
using System;


namespace Topic_18_Serialization_JsonSerializer
{
	class Program
	{
		static void Main(string[] args)
		{
			FullName fullName = new FullName();
			fullName.Surname = "Чукичев  ";
			fullName.Name = "Иван";
			fullName.Patronymic = "Федорович";

			
			// объект для сериализации			
			Person person = new Person();
			person.fullName = fullName;
			person.DateOfBirth = new DateTime(1999, 02, 22);
			person.Birthplace = "Тирасполь";
			person.PassportNumber = 123323;

			string json = JsonConvert.SerializeObject(person);
			Console.WriteLine("Объекс серриализован.");
			Console.WriteLine(json);
			Person person1 = JsonConvert.DeserializeObject<Person>(json);
			Console.WriteLine("Объекс десерриализован.");
			Console.WriteLine($"Surname = {person1.fullName.Surname} \nName = {person1.fullName.Name}  " +
							  $"\nPatronymic = {person1.fullName.Patronymic} \nDateOfBirth = {person1.DateOfBirth}" +
							  $"\nBirthplace = {person1.Birthplace} \nPassportNumber = {person1.PassportNumber}");
		}
	}
}
