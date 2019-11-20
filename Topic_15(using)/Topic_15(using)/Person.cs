using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_15_using_
{
	class Person : IDisposable

	{ 
		public string Name { get; set; }
		public void Dispose()
		{
			Console.WriteLine($" Сработал метод  - Disposed для обьекта {Name}");
		}
		
	}
}
