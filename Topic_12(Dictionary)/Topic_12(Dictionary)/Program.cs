using System;
using System.Collections.Generic;
using Topic_10_Equals_GetHashCode_;


namespace Topic_12_Dictionary_
{
	class Program
	{
		static void Main(string[] args)
		{

			Dictionary<Person, string> WorkBook = CreateColection();
			bool personIsFound;

			while (true)
			{
				personIsFound = false;

				Console.WriteLine("Введите Фамилию");
				string personSurname = Console.ReadLine();

				Console.WriteLine("Введите Имя");
				string personName = Console.ReadLine();

				Console.WriteLine("Введите Отчество");
				string personPatronymic = Console.ReadLine();

				foreach (var item in WorkBook)
				{
					if (item.Key.fullName.Surname == personSurname && item.Key.fullName.Name == personName && item.Key.fullName.Patronymic == personPatronymic)
					{
						Console.WriteLine($"Место работы - {item.Value}");
						personIsFound = true;
					}
					
				}
				if (!personIsFound)
				{
					Console.WriteLine("Нет совпадений. Возможно вы допустили ошибку в одном из параметров поиска.");
				}

				Console.WriteLine("_ _ _");
			}
		}

		public static Dictionary<Person, string> CreateColection()
		{
			FullName fullName1 = new FullName();
			fullName1.Surname = "Петров";
			fullName1.Name = "Юрий";
			fullName1.Patronymic = "Николаевич";
			DateTime dateOfBirth1 = new DateTime(2015, 07, 05);

			FullName fullName2 = new FullName();
			fullName2.Surname = "Крапачова";
			fullName2.Name = "Ирина";
			fullName2.Patronymic = "Владимировна";
			DateTime dateOfBirth2 = new DateTime(1987, 06, 02);

			FullName fullName3 = new FullName();
			fullName3.Surname = "Кирьяков";
			fullName3.Name = "Алексей";
			fullName3.Patronymic = "Иванович";
			DateTime dateOfBirth3 = new DateTime(1996, 05, 08);

			Person p1 = new Person(fullName1, dateOfBirth1, "Кишинев", 00000001);
			Person p2 = new Person(fullName2, dateOfBirth2, "Тирасполь", 00000002);
			Person p3 = new Person(fullName3, dateOfBirth3, "Рыбница", 00000003);

			Dictionary<Person, string> HandbookPlaceOfWork = new Dictionary<Person, string>
			{
				{ p1, "ПГУ им. Т.Г. Шевченко"},
				{ p2,"ТрансГаз"},
				{ p3,"ТирасЛифт"}
			};

			foreach (var item in HandbookPlaceOfWork)
			{
				Console.WriteLine("{0}-{1}", item.Key.fullName.Name, item.Value);
			}
			Console.WriteLine("_ _ _");
			return HandbookPlaceOfWork;
			
		}
	}
}
