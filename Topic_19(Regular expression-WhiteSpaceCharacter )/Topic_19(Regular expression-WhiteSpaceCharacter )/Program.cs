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
			Console.WriteLine("Результат:"+ DeleteWhiteSpace(text));
			
		}
		public static string DeleteWhiteSpace(string text)
		{
			Regex regex = new Regex(@"[ ]+");
			return (regex.Replace(text, " "));
		}
		
	}
}
