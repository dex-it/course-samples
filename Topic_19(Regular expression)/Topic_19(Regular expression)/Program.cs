using System;
using System.Text.RegularExpressions;

namespace Topic_19_Regular_expression_
{
	class Program
	{
		static MatchCollection f(string text, string start = "", string end="")
		{
			Regex regexSurname = new Regex($@"${start}\s\w*{end}");
			return regexSurname.Matches(text);
		}
		static void Main(string[] args)
		{
			
			string clientInformation = "Петров Сергей Генадиевич. тел.: 077951206. Женат ";
			string name = "";
			Console.WriteLine($"Исследуемые данные о клиенте: {clientInformation}");
			Console.WriteLine("_ _");



			Regex regexSurname = new Regex(@"\w*ов");
			Regex regexName = new Regex(@"ов\s\w*");
			Regex regexName2 = new Regex(@"\s\w*");
			Regex regexPatronymic = new Regex(@"(\w*вич)|(\w*вна)");
			Regex regexFonNumber = new Regex(@"[7]{2}[0-9]{6}");
			Regex regexMaritalStatus = new Regex(@"Женат|Холост",RegexOptions.IgnoreCase);

			MatchCollection matchesSurname = regexSurname.Matches(clientInformation);
			MatchCollection matchesName = regexName.Matches(clientInformation);
			MatchCollection matchesName2;
			MatchCollection matchesPatronymic = regexPatronymic.Matches(clientInformation);
			MatchCollection matchesFonNumber = regexFonNumber.Matches(clientInformation);
			MatchCollection matchesMaritalStatus = regexMaritalStatus.Matches(clientInformation);

			foreach (Match Surname in matchesSurname)
			{
				Console.WriteLine($"Surname = {Surname}");
			}

			foreach (Match Name in  matchesName)
			{
				Console.WriteLine($"Name = { Name}");
				name = Name.ToString();
			}
			matchesName2 = regexName2.Matches(name);
			foreach (Match Name2 in matchesName2)
			{
				Console.WriteLine($"Name = { Name2}");
			}


			foreach (Match Patronymic in matchesPatronymic)
			{
				Console.WriteLine($"Patronymic = { Patronymic}");
			}

			foreach (Match FonNumber in matchesFonNumber)
			{
				Console.WriteLine($"FonNumber = {FonNumber}");
			}

			foreach (Match MaritalStatus in matchesMaritalStatus)
			{
				Console.WriteLine($"MaritalStatus = {MaritalStatus}");
			}
			Console.WriteLine("_ _");

			Console.WriteLine("Производим замену семейного положения клиента");
			string pattern = @"женат";
			string targetMaritalStatus = "Холост";
			Regex regex1 = new Regex(pattern, RegexOptions.IgnoreCase);
			string result = regex1.Replace(clientInformation,targetMaritalStatus);
			Console.WriteLine(result);
			//Console.Read();
		}
	}
}
