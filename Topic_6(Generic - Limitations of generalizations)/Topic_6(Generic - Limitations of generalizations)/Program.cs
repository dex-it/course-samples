using System;

namespace Topic_6_Generic___Limitations_of_generalizations_
{
	class Program
	{
		static void Main(string[] args)
		{
			var color1 = new Color { Name = "Blue", Wavelength = 405 };
			var color2 = new Color { Name = "Green", Wavelength = 555 };
			var rectangle1 = new Rectangle { Height = 10, Width = 4 };
			var myBrush = new MyBrush<Color> { Color = color1 };

			myBrush.Draw(5);
			myBrush.DrawARectangle(color2, rectangle1);
		}
	}
}

