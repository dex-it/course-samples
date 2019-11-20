using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_1_OOP_
{
	public interface ICreatures
	{
		string Family { get; set; }// к кому  семейству отнсеться
		int Number_of_legs { get; set;} // количество конечностей
		bool It_Flies { get; set; }//летает ли оно?

		bool It_is_hungry(int timeOfLastFeeding, int FeedingFrequency);


	}
}
