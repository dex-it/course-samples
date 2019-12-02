using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_2_ICloneable_
{
	public class FullName
	{
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronymic { get; set; }

		public FullName DeepCopy()
		{
			return new FullName
			{
				Surname = Surname,
				Name = Name,
				Patronymic = Patronymic,
			};
		}
	}
}
