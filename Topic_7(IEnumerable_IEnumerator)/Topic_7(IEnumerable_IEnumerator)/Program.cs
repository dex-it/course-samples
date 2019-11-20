using System;
using System.Collections;

namespace Topic_7_IEnumerable_IEnumerator_
{
	class Program
	{
		static void Main(string[] args)
		{
			ExamplelWisIEnumerable();
			Console.WriteLine("_ - _ - _");
			ExamplelWisIEnumerator();	
		}

		public static void ExamplelWisIEnumerable()
		{
			Rainbow rainbow = new Rainbow();
			Console.WriteLine(" _ _ _ExamplelWisIEnumerable by foreach");
			foreach (var collor in rainbow)
			{
				Console.WriteLine(collor);
			}

			Console.WriteLine(" _ _ _ExamplelWisIEnumerable by while");
			int i = 0;
			while (i < rainbow.RainbowColors.Length)
			{
				Console.WriteLine(rainbow.RainbowColors[i]);
				i++;
			}
		}
		public static void ExamplelWisIEnumerator()
		{
			Week weekdays = new Week();
			Object item;
			Console.WriteLine(" _ _ _ ExamplelWisIEnumerator by while");
			while (weekdays.MoveNext())
			{
				item = weekdays.Current;
				Console.WriteLine(item);
			}

			Console.WriteLine(" _ _ _ ExamplelWisIEnumerator by foreach");
			foreach (var item2 in weekdays)
			{
				Console.WriteLine(item2);
			}
		}
	}
}
