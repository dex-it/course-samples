using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;

namespace Topic_6_Generic_UniqueCollection_
{
	public class UniqueCollection <T>:IEnumerable
	{
		private List<T> Collection = new List<T> { };
		
		public void AddElement(T element)
		{
			if (Collection.Contains(element))
			{
				throw new Exception("Такой элемент уже содержиться в коллекции!");
			}
			else
			{
				Collection.Add(element);
				Console.WriteLine("Элемент добавлен.");
			}

		}
		public List<T> GetCollection
		{
			get { return Collection; }
		}
		public IEnumerator GetEnumerator()
		{
			return ((IEnumerable)Collection).GetEnumerator();
		}
	}
}
