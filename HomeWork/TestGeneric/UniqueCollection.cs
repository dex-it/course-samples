using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TestUniqueCollections
{
    class UniqueCollection<T> : List<T>
    {
        public new void Add(T item)
        {
            bool isExist = false;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].GetHashCode() == item.GetHashCode())
                {
                    isExist = true;
                }
            }

            if (!isExist)
                base.Add(item);
            else
            {
                throw new Exception("Такой элемент уже существует");
            }

        }
    }
}
