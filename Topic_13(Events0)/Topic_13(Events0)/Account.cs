using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_13_Events0_
{
	class Account
	{
		public delegate void AccountHandler(string message);
		public event AccountHandler Notify;

		public Account(int sum)
		{
			Sum = sum;
		}

		public int Sum { get; private set; }

		public void Put(int sum)
		{
			Sum += sum;
			
			if (Notify!=null)
			{
				Notify($"На стчет поступило:{sum}");
			}
		}
		public void Take(int sum)
		{
			if (Sum>=sum)
			{
				Sum -= sum;
				Notify?.Invoke($"Со счета снято:  {sum}");
			}
			else
			{
				Notify?.Invoke($"Недостатоно денег на счете. Текущий баланс: {Sum}");
			}
		}

	}
}
