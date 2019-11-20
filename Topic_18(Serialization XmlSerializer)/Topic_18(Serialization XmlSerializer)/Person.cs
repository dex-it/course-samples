using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_18_Serialization_XmlSerializer_
{
	[Serializable]
	public class Person
	{
		public FullName fullName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Birthplace { get; set; }
		public int PassportNumber { get; set; }

	
		
	}
}
