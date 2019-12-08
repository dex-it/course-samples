using System;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Topic_18_Serializing_a_cyclic_object_
{
	class Program
	{
		static void Main(string[] args)
		{
			// объект для сериализации			
			Person person = new Person();
			person.Name = "Ivan";
			person.PassportNumber = 123323;

			Person person2 = new Person();
			person2.Name = "Petr";
			person2.PassportNumber = 123323;
			person2.Parent = person;
			
			person.Parent = person2;

			//JSONserialization(person2);
			BinarySerialization(person2);

		}

		public static void JSONserialization(Person person)
		{
			string json = JsonConvert.SerializeObject(person);
			Console.WriteLine("Объект серриализован.");
			Console.WriteLine(json);
			Person person1 = JsonConvert.DeserializeObject<Person>(json);
			Console.WriteLine("Объект десерриализован.");
			Console.WriteLine($"Name = {person1.Name}");
		}

		public static void BinarySerialization(Person person)
		{
			// создаем объект BinaryFormatter
			BinaryFormatter binariFormater = new BinaryFormatter();

			// получаем поток, куда будем записывать сериализованный объект
			using (FileStream fileStyeam = new FileStream("people.dat", FileMode.OpenOrCreate))
			{
				binariFormater.Serialize(fileStyeam, person);
				Console.WriteLine("Сериализация завершена");
			}

			// десериализация из файла people.dat
			using (FileStream fileStream = new FileStream("people.dat", FileMode.OpenOrCreate))
			{
				Person person1 = (Person)binariFormater.Deserialize(fileStream);
				Console.WriteLine("Десериализация завершена");
				Console.WriteLine($"Name = {person1.Name} PassportNumber = {person1.PassportNumber}" +
					$" Patern = {person1.Parent.Name} {person1.Parent.PassportNumber} ");
			}
		}
	}
}
