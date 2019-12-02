using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_6_Generic___Limitations_of_generalizations_
{
	public class MyBrush <T> where T: Color
	{
		public int Size { get; set; }
		public T Color { get; set; }

		public void Drow()
		{
			Console.WriteLine($"I'm draw a line 5 wide, with {Color.Name} color");
		}

		public void DrawARectangle<V>(T RecColor, V parameters) where V:Rectangle 
		{
			Console.WriteLine($"I'm draw a Rectangle {parameters.width} wide, {parameters.height} height, with {RecColor.Name} color");
		}
	}
}
