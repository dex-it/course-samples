using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_15_IDisposable_
{
	class Person : IDisposable
	{
		public string Name { get; set; }
		public void Dispose()
		{
			Console.WriteLine("Disposed");
		}
	}
}
