using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dex.ABolokan.Services.IEnumerableTask
{
	public class People : IEnumerable, IEnumerator
	{
		private readonly Person[] _people;

		public People(Person[] peopleArray)
		{
			_people = new Person[peopleArray.Length];

			for (int i = 0; i < peopleArray.Length; i++)
			{
				_people[i] = peopleArray[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _people.GetEnumerator();
		}

		public bool MoveNext()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public object Current { get; }
	}
}
