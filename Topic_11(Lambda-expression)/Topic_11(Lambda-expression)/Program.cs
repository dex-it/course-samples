using System;

namespace Topic_11_Lambda_expression_
{
	class Program
	{
		delegate int OperationDel(int x, int y);
		delegate bool IsEqualDel(int a);
		static void Main(string[] args)
		{
			OperationDel operation = (x, y) => x + y;
			Console.WriteLine(operation(4,7));

			Console.WriteLine("_ _Лямбда вырадение как аргумент метода_ _");
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 12, 14, 122 };
			int result_1 = GetSum(numbers, a => a < 3);
			Console.WriteLine(result_1);
			int result_2 = GetSum(numbers, a => a > 10);
			Console.WriteLine(result_2);
			Console.Read();

		}

		static int GetSum(int [] numbers,IsEqualDel isEqual)
		{
			int result = 0;
			foreach ( int i in numbers)
			{
				if (isEqual(i))
				{
					result += i;
				}
			}
			return result;
		}
	}

}
