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

			Console.WriteLine("Example with ref ");
			Console.WriteLine($"Before the chenging a = {a}, b = {b}");
			IncrimentXY(a,ref b);
			Console.WriteLine($"After the chenging a = {a}, b = {b}");

			Console.WriteLine("Example with  out ");
			Operation(a,b, out z, out e);
			Console.WriteLine($"z = {z}, e = {e}");

			Console.WriteLine("Example with  in ");
			Console.WriteLine($"Data = {GetData(5,4)}");
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
		static int GetData(in int x, int y)
		{
			return y = y + x;
			//return x = x + 10;// in не разрашает изменить значение X!
		}
	}

	
}
