using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Topic_7_IEnumerable_IEnumerator_
{
	class Week : IEnumerator
	{
		public string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
		int position = -1;
	   
		public object Current
		{
			get
			{
				if (position == -1 || position >= weekdays.Length)
				{
					throw new InvalidOperationException();
				}
				return weekdays[position];
			}
		}

		public bool MoveNext()
		{
			if (position< weekdays.Length-1)
			{
				position++;
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Reset()
		{
			position = -1;
		}
		//для работы с циклом foreach раскоментировать 
		public IEnumerator GetEnumerator()
		{
			return weekdays.GetEnumerator();
		}
	}
}
