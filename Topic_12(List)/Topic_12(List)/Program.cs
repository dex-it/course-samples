using System;
using System.Collections.Generic;

namespace Topic_12_List_
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> Colors = new List<string>() {"red", "orange", "yellow", "blue","purpure"};
			ShowList(Colors);
			Console.WriteLine("_ _ _");
			Colors.Add("black");
			ShowList(Colors);
			Console.WriteLine("_ _ _");
			Colors.AddRange(new string[] { "white", "brown", "gray" });
			ShowList(Colors);
			Console.WriteLine("_ _ _");
			Colors.Insert(3,"green");
			ShowList(Colors);
			Console.WriteLine("_ _ _");
			Colors.RemoveAt(6);
			ShowList(Colors);
			Console.WriteLine("_ _ _");
			Colors.Sort();
			ShowList(Colors);
			Console.WriteLine("_ _ _");
			Console.Read();
		}
		public static void ShowList(List<string>Eny)
		{
			foreach (string item in Eny)
			{
				Console.WriteLine(item);
			}
		}

	}
}
