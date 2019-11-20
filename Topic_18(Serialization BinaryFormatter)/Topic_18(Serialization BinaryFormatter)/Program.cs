using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Topic_18_Serialization_BinaryFormatter_
{
	class Program
	{
		static void Main(string[] args)
		{
			FullName fullName = new FullName();
			fullName.Surname = "Чукичев  ";
			fullName.Name = "Иван";
			fullName.Patronymic = "Федорович";

			DateTime dateOfBirth = new DateTime(1999, 02, 22);

			// объект для сериализации
			Person person = new Person(fullName,dateOfBirth,"Киев",12345);

			// создаем объект BinaryFormatter
			BinaryFormatter binariFormater = new BinaryFormatter();

			// получаем поток, куда будем записывать сериализованный объект
			using (FileStream fileStyeam = new FileStream("people.dat", FileMode.OpenOrCreate))
			{
				binariFormater.Serialize(fileStyeam, person);
				Console.WriteLine("Сериализация завершена");
			}

			// десериализация из файла people.dat
			using (FileStream fileStream = new FileStream("people.dat",FileMode.OpenOrCreate))
			{
				Person person1 = (Person)binariFormater.Deserialize(fileStream);
				Console.WriteLine("Десериализация завершена");
				Console.WriteLine($"Surname = {person1.fullName.Surname} \nName = {person1.fullName.Name} \nPatronymic = {person1.fullName.Patronymic}");
				Console.WriteLine($"dateOfBirth = {person1.DateOfBirth} \nBirthplace - {person1.Birthplace} \nPassportNumber - {person1.PassportNumber}");
			}
			Console.Read();

		}
	}
}
