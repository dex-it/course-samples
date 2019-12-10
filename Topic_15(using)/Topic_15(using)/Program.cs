using System;

namespace Topic_15_using_
{
	class Program
	{
		static void Main(string[] args)
		{
			Test1();
			Test3();			
		}

		public static void Test1()
		{
			using (var p = new Person { Name = "Tomm"})
			{
				// переменная p доступна только в блоке using
				Console.WriteLine($"Некоторые действия с объектом Person. Получим его имя: {p.Name}");
			}
		}

		public static void Test2()// у меня старая версия, так что данная реализация пока не доступна
		{
			//using Person p = new Person { Name = "Anna" };
			//Console.WriteLine($"Некоторые действия с объектом Person. Получим его имя: {p.Name}");
			//Console.WriteLine("Конец метода Test2");
		}

		public static void Test3()
		{
			using (var Alex = new Person { Name = "Alex"} )
			{
				using (var Mishel = new Person { Name = "Mishel"})
				{
					Console.WriteLine($"I объект {Alex.Name} ,  II объект {Mishel.Name}");
				}//вызов метода Dispose для обьека Mishel

			}//вызов метода Dispose для обьека Alex
			Console.WriteLine("Конец метода");
		}
	}
}
