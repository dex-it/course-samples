using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_18_Serialization_XmlSerializer_
{
	[Serializable]
	public class FullName
	{

		public string Surname { get; set; }
		public string Name { get; set; }
		public string Patronymic { get; set; }
		
		
	}
}
