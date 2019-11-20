using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_10_Equals_GetHashCode_
{
	public class Person
	{
		public FullName fullName{get; }
		public DateTime DateOfBirth { get; }
		public string Birthplace { get; }
		public int PassportNumber { get; }

		public Person(FullName fullName, DateTime dateOfBirth, string birthplace, int passportNumber)
		{
			this.fullName = fullName;
			DateOfBirth = dateOfBirth;
			Birthplace = birthplace;
			PassportNumber = passportNumber;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is Person))
			{
				return false;
			}
			var person = (Person)obj;
			return (person.DateOfBirth == DateOfBirth && person.Birthplace == Birthplace && person.PassportNumber == PassportNumber);
		}

		public override int GetHashCode()
		{

			return (fullName.GetHashCode() - DateOfBirth.GetHashCode() - Birthplace.GetHashCode() - PassportNumber.GetHashCode());
		}

	}
}
