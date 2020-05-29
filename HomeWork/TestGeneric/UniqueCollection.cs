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
            if (!this.Contains(item))
                base.Add(item);
            else
            {
                throw new Exception("Такой элемент уже существует");
            }
        }
    }
}
