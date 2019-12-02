using System;

namespace Topic_6_Generic___Limitations_of_generalizations_
{
	class Program
	{
		static void Main(string[] args)
		{
			Color color1 = new Color { Name = "Blue", Wavelength = 405 };
			Color color2 = new Color { Name = "Green", Wavelength = 555 };
			Rectangle rectangle1 = new Rectangle { height = 10, width = 4 };//
			MyBrush<Color> myBrush = new MyBrush<Color> { Color = color1, Size = 5 };

			myBrush.Drow();
			myBrush.DrawARectangle(color2, rectangle1);
			
		}
	}
}
