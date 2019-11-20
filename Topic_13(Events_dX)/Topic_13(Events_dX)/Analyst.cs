using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Topic_13_Events_dX_
{
	public class Analyst
	{
		public delegate void numberHandle(string mesage);
		public event numberHandle dXEvent;
		public int Number { get; set; }
		List<int> Sampl = new List<int>();
		private int x;
		public Analyst(int x)
		{
			this.x = x;//передаем процент отклонения от общей выборки, выше которого сработает событие
			
		}
		public void Analysis(int number)
		{
			int medium;
			int summ = 0;
			Sampl.Add(number);
			
			for (int i = 0; i < Sampl.Count; i++)
			{
				summ = summ + Sampl[i];				
			}
			medium = summ / Sampl.Count;
			CalculatedX(number,medium);			
			Thread.Sleep(500);
		}

		private void CalculatedX(int number, int medium)
		{
			double onePercent = ((double)medium / 100);
			if (number > medium)
			{				
				double dX = ((double)number/onePercent)-100;				
				if (x < dX)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					dXEvent?.Invoke($"Текущее число ({number}), на  ({dX}%) превышает среднего ({medium}) значение ряда при пороге ({x}%)!");
				}
			}
			else if (number < medium)
			{				
				double mediumInPercent = medium / onePercent;
				double dX = 100 - ((double)number / onePercent);				
				if (x < dX)
				{
					Console.ForegroundColor = ConsoleColor.Cyan;
					dXEvent?.Invoke($"Текущее число ({number}), более чем на  ({x}%) ниже среднего ({medium}) значения ряда при пороге ({x}%)!");
				}
			}
		}
	}
}
