using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_1_OOP_
{
	class MyCat : Cats
	{
		//public string CatName;
		public MyCat(string name)
		{
			CatName = name;
		}
		
		public void FeedTheCat()
		{
			Console.WriteLine($"I feed the {CatName}");
			Console.WriteLine($"{CatName} is happy.");
		}

		public override void PlayWithTheCat()
		{
			Console.WriteLine($"I play wiht {CatName}");
		}
	}
}
