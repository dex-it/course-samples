using System;
using System.IO;
using System.Xml.Serialization;

namespace Topic_18_Serialization_XmlSerializer_
{
	class Program
	{
		static void Main(string[] args)
		{
			var f = new FullName() { Name = "Семен", Patronymic = "Анатольевич", Surname = "Богатый" };
			
			// объект для сериализации			
			var person1 = new Person();
			person1.fullName = f;
			person1.DateOfBirth = new DateTime(1982, 12, 22);
			person1.Birthplace = "Мурманск";
			person1.PassportNumber = 15326;

			Console.WriteLine("Создан объект для серриализации");

			// передаем в конструктор тип класса
			var xmlFormater = new XmlSerializer(typeof(Person));

			// получаем поток, куда будем записывать сериализованный объект
			using (var fileStream = new FileStream("person.xml",FileMode.OpenOrCreate))
			{
				xmlFormater.Serialize(fileStream, person1);
				Console.WriteLine("Объкт сериализован");			
			}

			// десериализация
			using (var fileStream1 = new FileStream("person.xml", FileMode.OpenOrCreate))
			{
				var person2 = (Person)xmlFormater.Deserialize(fileStream1);

				Console.WriteLine("Объект десериализован");
				Console.WriteLine("_ _ _");
				Console.WriteLine($"Surname - {person2.fullName.Surname} \nName - {person2.fullName.Name} \nPatronymic - {person2.fullName.Patronymic}");
				Console.WriteLine($"DateOfBirth - {person2.DateOfBirth} \nBirthplace - {person2.Birthplace} \nPassportNumber - {person2.PassportNumber}");
			}
		}
	}
}
