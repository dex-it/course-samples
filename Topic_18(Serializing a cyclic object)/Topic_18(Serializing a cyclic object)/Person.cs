using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_18_Serializing_a_cyclic_object_
{
	public class Person
	{	
	    public string Name { get; set; }
		public int PassportNumber { get; set; }
		Person person = new Person();

	}
}
