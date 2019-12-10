using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_10_Equals_GetHashCode_
{
	public class FullName
	{		
		public string Surname { get; set; }
		public string  Name { get; set;}
		public string Patronymic { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is FullName))
			{
				return false;
			}

			var fullName = (FullName)obj;

			return (fullName.Surname == Surname && fullName.Name == Name && fullName.Patronymic == Patronymic) ;
		}
		public override int GetHashCode()
		{
			int SurnameHashCode = Surname.GetHashCode();
			int NameHashCode = Name.GetHashCode();
			int PatronymicHashCode = Patronymic.GetHashCode();	
			
			return (SurnameHashCode + NameHashCode + PatronymicHashCode);
		}
	}
}
