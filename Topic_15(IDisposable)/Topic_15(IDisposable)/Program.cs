using System;

namespace Topic_15_IDisposable_
{
	class Program
	{
		static void Main(string[] args)
		{
			Test();
			Console.ReadLine();
		}
		private static void Test()
		{
			Person p = null;
			try
			{
				p = new Person();
			}
			finally
			{
				if (p!= null)
				{
					p.Dispose();
				}
			}
		}
	}
}
