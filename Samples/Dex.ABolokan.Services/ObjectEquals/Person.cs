using System;
using System.Collections.Generic;
using System.Text;

namespace Dex.ABolokan.Services.ObjectEquals
{
	public class Person
	{
		public string FirstName;
		public string LastName;
		public string MidleName { get; set; }
		public DateTime Dob { get; set; }
		public string Place { get; set; }
		public string PassportId { get; set; }


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
			return person.FirstName == FirstName &&
				   person.LastName == LastName &&
				   person.MidleName == MidleName &&
				   person.Dob == Dob &&
				   person.Place == Place &&
				   person.PassportId == PassportId;


		}


		public override int GetHashCode()
		{

			var fLenght = (FirstName != null ? FirstName.Length : 0);
			var lfLenght = (LastName != null ? LastName.Length : 0);
			var mLenght = (MidleName != null ? MidleName.Length : 0);
			var dLenght = Dob.ToString("d").Length;
			var plfLenght = (Place != null ? Place.Length : 0);
			var pfLenght = (PassportId != null ? PassportId.Length : 0);

			return fLenght + lfLenght + mLenght + dLenght + plfLenght + pfLenght;


			//unchecked
			//{
			//	var hashCode = (FirstName != null ? FirstName.GetHashCode() : 0);
			//	hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
			//	hashCode = (hashCode * 397) ^ (MidleName != null ? MidleName.GetHashCode() : 0);
			//	hashCode = (hashCode * 397) ^ Dob.GetHashCode();
			//	hashCode = (hashCode * 397) ^ (Place != null ? Place.GetHashCode() : 0);
			//	hashCode = (hashCode * 397) ^ (PassportId != null ? PassportId.GetHashCode() : 0);
			//	return hashCode;
			//}
		}
	}
}
