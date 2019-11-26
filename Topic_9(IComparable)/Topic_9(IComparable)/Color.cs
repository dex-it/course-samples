using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_9_IComparable_
{
	class Color : IComparable
	{
		public string ColorName { get; set; }
		public int WavelengthOfLight { get; set; }
		public int CompareTo(object obj)
		{
			Color color = obj as Color;

			if (color !=null)
			{
				return this.ColorName.CompareTo(color.ColorName);
			}
			else
			{
				throw new Exception("Невохможно сравнить два обьекта");
			}
		
		}
	}
}
