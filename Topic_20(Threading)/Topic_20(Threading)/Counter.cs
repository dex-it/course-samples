using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Topic_20_Threading_
{
	public class Counter
	{
		public int x;
		public int y;
		public Counter(int _x, int _y)
		{
			this.x = _x;
			this.y = _y;
		}

		public void Count()
		{
			for (int i = 1; i < 9; i++)
			{
				Console.WriteLine("Второй поток:");
				Console.WriteLine(i * x * y);
				Thread.Sleep(400);
			}
		}
	}
}
