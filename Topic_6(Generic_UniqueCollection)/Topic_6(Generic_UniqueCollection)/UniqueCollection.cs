using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Topic_6_Generic_UniqueCollection_
{
	public class UniqueCollection <T>:IEnumerable
	{
		private readonly SortedSet<T> _collection = new SortedSet<T>();
		
		public void AddElement(T element)
		{
			if (_collection.Contains(element))
			{
				throw new Exception("Такой элемент уже содержиться в коллекции!");
			}
			else
			{
				_collection.Add(element);
				Console.WriteLine("Элемент добавлен.");
			}

		}

		public IEnumerator GetEnumerator()
		{
			return ((IEnumerable)_collection).GetEnumerator();
		}
	}
}
