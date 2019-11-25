using System;
using System.Text.RegularExpressions;


namespace Topic_19_Regular_expression_WhiteSpaceCharacter__
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "qweqwr  qerqet    qwrtttqw qwrqrt    wrwrw";
			Console.WriteLine("Исходная строка:" + text);
			Console.WriteLine("Результат1: "+ Exampe_1(text));
			Console.WriteLine("Результат2: " + Exampe_2(text));

		}
		public static string Exampe_1(string text)
		{
			Regex regex = new Regex(@"[ ]+");
			return (regex.Replace(text, " "));
		}
		public static string Exampe_2(string text)
		{
			
			return (text.Replace("  "," "));
		}

	}
}
