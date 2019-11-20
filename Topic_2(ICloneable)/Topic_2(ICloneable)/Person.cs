using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_2_ICloneable_
{
	public class Person : ICloneable
	{
		public FullName fullName { get; set; }
		public string birthPlace { get; set; }
		public DateTime dateOfBirth { get; set; }

		public object Clone()
		{
			FullName fullName2 = new FullName
			{
				Surname = this.fullName.Surname,
				Name = this.fullName.Name,
				Patronymic = this.fullName.Patronymic
			};

			return new Person { fullName = fullName2, birthPlace = this.birthPlace, dateOfBirth = this.dateOfBirth };
		}
	}
}
