using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_16_Extension_methods_
{
	public static class MyMathExtension
	{
		public static int Division(this MyMath myM, int x , int y)
		{
			int result = 0;

			try
			{				
				result = x / y;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return (result);
		}

		public static int Multiple(this MyMath myM, int x, int y)
		{
			return (x * y);
		}
	}
}
