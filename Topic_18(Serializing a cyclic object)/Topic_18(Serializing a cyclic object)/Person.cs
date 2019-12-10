using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_18_Serializing_a_cyclic_object_
{
	[Serializable]
	public class Person
	{	
	    public string Name { get; set; }
		public int PassportNumber { get; set; }		
		public Person Parent { get; set; }
	}
}
