using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Topic_19_Regular_expression___string_parameters_
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "http://ya.ru/api?r=1&x=23";
			var parameters = new Dictionary<string, string>();

			parameters = ExtractSettings(s);
			Console.WriteLine($"Образец = {s}");
			Console.WriteLine($"Результат:");

			foreach (var item in parameters)
			{
				Console.WriteLine($"{item.Key} = {item.Value}");				
			}
			
		}
		public static Dictionary<string, string> ExtractSettings(string s)
		{
			//ИЗВЛЕКАЕМ ПАРАМЕТРЫ ИЗ CТРОКИ
			var parameters = new Dictionary<string, string>();
			var regexKey = new Regex(@"\w(?==)");
			var regexValue = new Regex(@"(?<==)\w*");
			var keyCollection = regexKey.Matches(s);
			var valueCollection = regexValue.Matches(s);

			for (int i = 0; i < keyCollection.Count; i++)
			{
				parameters.Add(keyCollection[i].ToString(), valueCollection[i].ToString());
			}

			return parameters;
		}
	}
}
