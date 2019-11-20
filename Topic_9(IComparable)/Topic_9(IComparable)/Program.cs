using System;

namespace Topic_9_IComparable_
{
	class Program
	{
		static void Main(string[] args)
		{
			Color color1 = new Color { ColorName = "Read",  WavelengthOfLight = 650 };
			Color color2 = new Color { ColorName = "Green", WavelengthOfLight = 555 };
			Color color3 = new Color { ColorName = "Blue",  WavelengthOfLight = 450 };
			Color color4 = new Color { ColorName = "Violet",WavelengthOfLight = 400 };
			Color color5 = new Color { ColorName = "Orange",WavelengthOfLight = 590 };

			Color[] Spectrum = new Color[] { color1, color2, color3, color4, color5 };
			Array.Sort(Spectrum);
			foreach (Color c in Spectrum)
			{
				Console.WriteLine($"{c.ColorName} - {c.WavelengthOfLight}");
			}

			Console.WriteLine("_ _ _");
			Array.Sort(Spectrum, new ColorComparer());
			foreach (Color c in Spectrum)
			{
				Console.WriteLine($"{c.ColorName} - {c.WavelengthOfLight}");
			}
			Console.Read();
		}
	}
}
