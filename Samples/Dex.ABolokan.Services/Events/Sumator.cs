using System.Collections.Generic;
using System.Linq;

namespace Dex.ABolokan.Services.Events
{
	public class Sumator
	{
		public delegate void MessageEventHandler(double sum);

		public event MessageEventHandler Notify;

		private double _totalSum;

		public void Push(List<double> items)
		{
			TotalSum = items.Sum();
		}

		private double TotalSum
		{
			set
			{
				_totalSum = value;
				Notify?.Invoke(value);
			}
		}
	}
}
