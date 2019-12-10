using System;
using System.Reflection;

namespace Topic_17_Reflection_
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var asm = Assembly.LoadFrom("Topic_17RTest.dll");
				var type = asm.GetType("Topic_17RTest.Car", true, true);

				ShowFilds(type);//вывести инвормацию о полях исследооуемого класса

				ShowProperties(type);//вывести инвормацию о cвойствах исследооуемого класса

				ShowCtor(type); //вывести инвормацию о конструкторах исследооуемого класса

				ShowMethods(type); // вывести инвормацию о методох исследооуемого класса

				WorckWithMethod(type); // продемеонстрировать работу с медотами исследуемого класса
				
				
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}

		public static void ShowFilds(Type type)
		{
			Console.WriteLine("Поля:");

			foreach (var field in type.GetFields())
			{
				Console.WriteLine($"{field.FieldType.Name} {field.Name}");
			}
			Console.WriteLine("_ _ _ _ _");
		}
		public static void ShowProperties(Type type)
		{
			Console.WriteLine("Свойства:");

			foreach (var properties in type.GetProperties())
			{
				Console.WriteLine($"{properties.PropertyType.Name} {properties.Name}");
			}
			Console.WriteLine("_ _ _ _ _");
		}
		public static void ShowCtor(Type type)
		{
			Console.WriteLine("Конструкторы:");

			foreach (var ctor in type.GetConstructors())
			{
				Console.WriteLine(type.Name + "(");
				//получение параметров
				var parameters = ctor.GetParameters();

				for (int i = 0; i < parameters.Length; i++)
				{
					Console.WriteLine($"{parameters[i].ParameterType.Name}  {parameters[i].Name}");
				}
				Console.WriteLine(")");
			}
			Console.WriteLine("_ _ _ _ _");
		}

		public static void ShowMethods(Type type)
		{
			Console.WriteLine("Методы: ");

			foreach (var method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public))
			{
				string modifier = " ";

				if (method.IsStatic)
				{
					modifier = "static";
				}
				if (method.IsVirtual)
				{
					modifier = "virtual";
				}
				if (method.IsPublic)
				{
					modifier = "public";
				}

				Console.WriteLine($"{modifier} {method.ReturnType.Name} {method.Name}");
			}
			Console.WriteLine("_ _ _ _ _");
		}		

		public static void WorckWithMethod(Type type)
		{
			Console.WriteLine("Пример работы с методом исследуемого класса:");
			//создаем экземпляр каасса Car
			object obj = Activator.CreateInstance(type);

			//Получаем метод GetMessage
			MethodInfo method = type.GetMethod("Speed");

			// Вызаваем метод передаем ему значение для параметров и получаем разультат
			object result = method.Invoke(obj, new object[] { 10, 5 });
			Console.WriteLine($"result = {result}");
			Console.WriteLine("_ _ _ _ _");
		}

	}
}
