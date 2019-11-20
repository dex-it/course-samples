using System;

namespace Topic_2_ICloneable_
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Person anna = new Person
			{
				fullName = new FullName{ Name = "Анна", Patronymic = "Семеновна", Surname = "Крапачёва" },
				dateOfBirth = new DateTime(1989,5,22),
				birthPlace = "Кишинев"
			};
			Person elen = (Person)anna.Clone();
			Console.WriteLine($"FullName for (elen) after clone - {elen.fullName.Surname} {elen.fullName.Name} {elen.fullName.Patronymic}");
			Console.WriteLine($"dateOfBirth = {elen.dateOfBirth}");
			Console.WriteLine("_ _ _");
			Console.WriteLine("We change the object (elen)");
			elen.fullName.Name = "Семен";
			elen.dateOfBirth = new DateTime(1800, 1, 1);
			Console.WriteLine($"Name = {elen.fullName.Name} dateOfBirth = {elen.dateOfBirth} ");
			Console.WriteLine("_ _ _");			
			Console.WriteLine($"object (anna): \nName = {anna.fullName.Name} \ndateOfBirth={anna.dateOfBirth}");
		}
	}
}
