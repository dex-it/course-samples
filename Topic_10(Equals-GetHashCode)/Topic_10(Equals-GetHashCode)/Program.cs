using System;

namespace Topic_10_Equals_GetHashCode_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("_ _ _");
			var fullName1 = new FullName();
			fullName1.Surname = "Петров";
			fullName1.Name = "Юрий";
			fullName1.Patronymic = "Николаевич";

			var fullName2 = new FullName();
			fullName2.Surname = "Крапачова";
			fullName2.Name = "Ирина";
			fullName2.Patronymic = "Владимировна";

			var fullName3 = new FullName();
			fullName3.Surname = "Крапачова";
			fullName3.Name = "Ирина";
			fullName3.Patronymic = "Владимировна";


			var dateTime1 = new DateTime(2015, 07, 05);
			var dateTime2 = new DateTime(1996, 09, 12);

			var person1 = new Person(fullName1, dateTime1, "Тирасполь", 01102);
			var person2 = new Person(fullName2, dateTime2, "Рыбница", 12101);
			var person3 = new Person(fullName3, dateTime2, "Рыбница", 12101);
			

			Console.WriteLine($" person3.Equals(person1) = {person3.Equals(person1)} \n person3.Equals(person2) = {person3.Equals(person2)} \n");
			Console.WriteLine("_ _ _");
			Console.WriteLine($" person1.GetHashCode() = {person1.GetHashCode()} " +
							  $"\n person2.GetHashCode() = {person2.GetHashCode()} " +
							  $"\n person3.GetHashCode() = {person3.GetHashCode()} ");

			bool t = person2 == person3;
			Console.WriteLine($"t = {t}");


		}
		
	}
}
