using System;
using System.Collections;
using System.Text;

namespace Topic_7_IEnumerable_IEnumerator_
{
	class Rainbow:IEnumerable
	{
		public string[] RainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet"};

		public IEnumerator GetEnumerator()
		{
			return RainbowColors.GetEnumerator();
		}
	}
}
