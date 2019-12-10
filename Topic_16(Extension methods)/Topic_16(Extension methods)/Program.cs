using System;

namespace Topic_16_Extension_methods_
{
	class Program
	{
		static void Main(string[] args)
		{
			var myMath = new MyMath();
			int a = 5;
			int b = 2;

			Console.WriteLine($"{a} + {b} = {myMath.Sum(a, b)}");
			Console.WriteLine($"{a} - {b} = {myMath.Subtraction(a, b)}");
			Console.WriteLine($"{a} / {b} = {myMath.Division(a,b)}");
			Console.WriteLine($"{a} * {b} = {myMath.Multiple(a, b)}");
		}
	}
}
