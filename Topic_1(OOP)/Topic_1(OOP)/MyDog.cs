using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_1_OOP_
{
	class MyDog : ICreatures
	{
		public string Family { get; set; }
		public string Name { get; set; }
		int ICreatures.Number_of_legs { get; set ; }
		bool ICreatures.It_Flies { get; set; }

		public MyDog(string Name)
		{
			this.Name = Name;
		}
		bool ICreatures.It_is_hungry(int timeOfLastFeeding, int FeedingFrequency)
		{
			if (timeOfLastFeeding <= FeedingFrequency)
			{
				Console.WriteLine(Name + " is not hungry");
				return false;
			}
			else
			{
				Console.WriteLine(Name + " is hungry");
				return true;
			}
		}
	}
}
