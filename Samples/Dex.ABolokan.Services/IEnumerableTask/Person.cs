using System;
using System.Collections.Generic;
using System.Text;

namespace Dex.ABolokan.Services.IEnumerableTask
{
	public class Person
	{
		public Person(string fName, string lName)
		{
			this.FirstName = fName;
			this.LastName = lName;
		}

		public string FirstName;
		public string LastName;
	}
}
