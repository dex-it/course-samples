using System;

namespace Topic_11_AnonymousMethod_
{
	class Program
	{
		delegate void MessageHandler(string message);
		static void Main(string[] args)
		{
			MessageHandler handler = delegate(string mes)
			{
				Console.WriteLine(mes);
				Console.WriteLine("ko");
			};
			handler("s3po");
			Console.Read();
		}
	}
}
