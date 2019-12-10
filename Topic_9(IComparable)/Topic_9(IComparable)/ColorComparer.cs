using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Topic_9_IComparable_
{
	class ColorComparer : IComparer<Color>
	{
		public int Compare(Color color1, Color color2)
		{
			
			if (color1.WavelengthOfLight> color2.WavelengthOfLight)
			{
				return 1;
			}
			else if (color1.WavelengthOfLight < color2.WavelengthOfLight)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}
	}
}
