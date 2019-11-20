using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_1_OOP_
{
	public abstract class Cats:ICreatures
	{
		public string Family { get; set; }
		public string CatName;
		public int Number_of_legs
		{
			get { return 4; }
			set { }
		}
		public bool It_Flies
		{
			get { return false; }
			set { }
		}

		public bool It_is_hungry(int timeOfLastFeeding, int FeedingFrequency)
		{
			
			if (timeOfLastFeeding  <= FeedingFrequency)
			{
				Console.WriteLine(CatName + " is not hungry");
				return false;
			}
			else
			{
				Console.WriteLine(CatName + " is hungry");
				return true;
			}
		}

		public abstract void PlayWithTheCat();
		
	}
}
