using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Topic_11_Delegate_
{
	public class Operation
	{
		public int Add(int a, int b)
		{
			int c = a + b;
			Console.WriteLine("a + b = " + c);
			return c;
		}
		public int Subtract(int a, int b)
		{			
			int c = a - b;
			Console.WriteLine("a - b =" + c);		
			return c;
		}
	}
}
