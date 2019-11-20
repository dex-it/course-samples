using System;

namespace Topic_11_Delegate_
{
	class Program
	{
		delegate void MessageDel();
		delegate int CalcDel(int x, int y);
		static void Main(string[] args)
		{
			Fruits fruits = new Fruits();
			MessageDel message = fruits.Apple;
			message += fruits.Lemon;
			message += fruits.Pear;
			message += fruits.Lemon;
			message();

			Console.WriteLine("_ _Вызов делегата с помощю метода Invoke()_ _");
			Operation operation = new Operation();
			CalcDel calc = operation.Subtract;
			calc += operation.Add;
			calc.Invoke(5,3);

			Console.WriteLine("_ _Делегат как параметр метода_ _");
			Time time = new Time();
			if (DateTime.Now.Hour < 12)
			{
				Welcome(time.GoodMorning);
			}
			else
			{
				Welcome(time.GoodEvening);
			}

			//Console.Read();
		}

		static void Welcome(MessageDel message2)
		{
			message2.Invoke();
		}


	}
}
