using System;

namespace Topic_2_ICloneable_
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Person anna = new Person
			{
				FullName = new FullName{ Name = "Анна", Patronymic = "Семеновна", Surname = "Крапачёва" },
				DateOfBirth = new DateTime(1989,5,22),
				BirthPlace = "Кишинев"
			};
			Person elen = (Person)anna.Clone();
			
			Console.WriteLine($"FullName for (elen) after clone - {elen.FullName.Surname} {elen.FullName.Name} {elen.FullName.Patronymic}");
			Console.WriteLine($"dateOfBirth = {elen.DateOfBirth}");
			Console.WriteLine("_ _ _");
			Console.WriteLine("We change the object (elen)");
			
			elen.FullName.Name = "Семен";
			elen.DateOfBirth = new DateTime(1800, 1, 1);
			
			Console.WriteLine($"Name = {elen.FullName.Name} dateOfBirth = {elen.DateOfBirth} ");
			Console.WriteLine("_ _ _");			
			Console.WriteLine($"object (anna): \nName = {anna.FullName.Name} \ndateOfBirth={anna.DateOfBirth}");
		}
	}
}
