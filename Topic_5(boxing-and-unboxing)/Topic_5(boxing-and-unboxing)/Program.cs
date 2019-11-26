using System;

namespace Topic_5_boxing_and_unboxing_
{
	class Program
	{		static void Main(string[] args)
		{
			Console.WriteLine("_ _ _ boxing _ _ _");
			int a = 123;
			object Sempl1 = a;
			a = 2;
			Console.WriteLine($"Sempl1 = {Sempl1}");
			Console.WriteLine($"a = {a}");

			Console.WriteLine("_ _ _ boxing _ _ _");
			bool State = true;
			object Sempl2 = State;
			State = false;
			Console.WriteLine($"Sempl2 = {Sempl2}");
			Console.WriteLine($"State = {State}");

			Console.WriteLine("_ _ _ unboxing _ _ _");
			try
			{
				int b = (int)Sempl1;
				bool State2 = (bool)Sempl2;
				//b = (int)Sempl2;// пример попытки некоректной распаковки, с несоответствием типов
				Console.WriteLine($"b = {b}");
				Console.WriteLine($"State2 = {State2}");
			}
			catch (InvalidCastException e )
			{
				Console.WriteLine(e.Message);				
			}
		}
	}
}
