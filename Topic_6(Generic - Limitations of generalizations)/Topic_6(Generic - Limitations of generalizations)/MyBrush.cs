using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_6_Generic___Limitations_of_generalizations_
{
	public class MyBrush <T> where T: Color
	{
		
		public T Color { get; set; }

		public void Draw(int Size) 
		{
			Console.WriteLine($"I'm draw a line {Size} width, with {Color.Name} color");
		}

		public void DrawARectangle<V>(T RecColor, V parameters) where V:Rectangle 
		{
			Console.WriteLine($"I'm draw a Rectangle {parameters.Width} wide, {parameters.Height} height, with {RecColor.Name} color");
		}
	}
}
