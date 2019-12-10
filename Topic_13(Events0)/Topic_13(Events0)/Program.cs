using System;

namespace Topic_13_Events0_
{
	class Program
	{
		static void Main(string[] args)
		{
			var account = new Account(100);
			account.Notify += DisplayRedMessage;
			account.Notify += DisplayGreenMessage;

			account.Put(20);
			Console.WriteLine($"Сума на счете:{account.Sum}");

			account.Take(70);
			account.Notify -= DisplayGreenMessage;
			Console.WriteLine($"Сума на счете:{account.Sum}");

			account.Take(180);
			Console.WriteLine($"Сума на счете:{account.Sum}");
			
		}

		public static void DisplayRedMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void DisplayGreenMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(message);
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
