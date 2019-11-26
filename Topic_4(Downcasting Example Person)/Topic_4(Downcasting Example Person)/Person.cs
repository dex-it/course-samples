using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_4_Downcasting_Example_Person_
{
	class Person
	{
		public string FirstName{get; set;}
		public string LastName{get; set;}

		public static explicit operator Person(string text)
		{			
			try
			{				
				string[] words = text.Split(new char[] { ' ' });
				Person person = new Person { FirstName = words[0], LastName = words[1] };
				return person;				
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			throw new Exception("Обьект класса Person  может принимать в качестве памраметра только Имя и Фамилию!");			
		}
	}
}
