using System;

namespace Topic_9_IComparable_
{
	class Program
	{
		static void Main(string[] args)
		{
			var color1 = new Color { ColorName = "Read",  WavelengthOfLight = 650 };
			var color2 = new Color { ColorName = "Green", WavelengthOfLight = 555 };
			var color3 = new Color { ColorName = "Blue",  WavelengthOfLight = 450 };
			var color4 = new Color { ColorName = "Violet",WavelengthOfLight = 400 };
			var color5 = new Color { ColorName = "Orange",WavelengthOfLight = 590 };

			var Spectrum = new Color[] { color1, color2, color3, color4, color5 };


			Console.WriteLine("_ _ Пример использования IComparable _");
			Array.Sort(Spectrum);

			foreach (Color c in Spectrum)
			{
				Console.WriteLine($"{c.ColorName} - {c.WavelengthOfLight}");
			}

			Console.WriteLine("_ _ _");



			Console.WriteLine("_ _ Пример использования IComparer<T> _");
			Array.Sort(Spectrum, new ColorComparer());

			foreach (Color c in Spectrum)
			{
				Console.WriteLine($"{c.ColorName} - {c.WavelengthOfLight}");
			}

			Console.WriteLine("_ _ _");
			
		}
	}
}
