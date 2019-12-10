using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Topic_18_Serialization_BinaryFormatter_
{
	class Program
	{
		static void Main(string[] args)
		{
			var fullName = new FullName();

			fullName.Surname = "Чукичев  ";
			fullName.Name = "Иван";
			fullName.Patronymic = "Федорович";

			var dateOfBirth = new DateTime(1999, 02, 22);

			// объект для сериализации
			var person = new Person(fullName,dateOfBirth,"Киев",12345);

			// создаем объект BinaryFormatter
			var binariFormater = new BinaryFormatter();

			// получаем поток, куда будем записывать сериализованный объект
			using (var fileStyeam = new FileStream("people.dat", FileMode.OpenOrCreate))
			{
				binariFormater.Serialize(fileStyeam, person);
				Console.WriteLine("Сериализация завершена");
			}

			// десериализация из файла people.dat
			using (var fileStream = new FileStream("people.dat",FileMode.OpenOrCreate))
			{
				var person1 = (Person)binariFormater.Deserialize(fileStream);

				Console.WriteLine("Десериализация завершена");
				Console.WriteLine($"Surname = {person1.fullName.Surname} \nName = {person1.fullName.Name} \nPatronymic = {person1.fullName.Patronymic}");
				Console.WriteLine($"dateOfBirth = {person1.DateOfBirth} \nBirthplace - {person1.Birthplace} \nPassportNumber - {person1.PassportNumber}");
			}
			
		}
	}
}
