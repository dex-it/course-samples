using System;

namespace Topic_3_in_out_ref_
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 5;
			int z;
			int e;

			Console.WriteLine("example with _ ref _");
			Console.WriteLine($"Before the chenging a = {a}, b = {b}");
			IncrimentXY(a,ref b);
			Console.WriteLine($"After the chenging a = {a}, b = {b}");

			Console.WriteLine("example with _ out _");
			Operation(a,b, out z, out e);
			Console.WriteLine($"z = {z}, e= {e}");

			Console.Read();
		}

		static void IncrimentXY(int x, ref int y)
		{
			x++;
			y++;
			Console.WriteLine($"x = {x} y = {y}");
		}

		static void Operation(int x, int y, out int z, out int e)
		{
			z = x + y;
			e = x * y;
		}
		static void GetData(in int x, int y)
		{
			y = y + x;
			//x = x + 10;// in не разрашаеи изменить значение X
		}
	}

	
}
