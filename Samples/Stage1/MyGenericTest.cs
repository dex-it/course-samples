using System;
using System.Collections.Generic;
using System.Security.Claims;
using NUnit.Framework;

namespace Stage1
{
    public class MyGenericTest
    {
        /// <summary>
        /// Коллекцию которая хранит только уникальные объекты UniqueCollection<T>,
        /// при попытке добавить существующий инстанс, выбрасывает исключение
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class UniqueCollection<T>
        {
            private List<T> _list { get; set; }
            public UniqueCollection()
            {
                _list=new List<T>();
            }

            public void Add(T item)
            {
                
                if (_list.Contains(item))
                {
                    throw new ArgumentException("Item already exist");
                }

                try
                {
                    _list.Add(item);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        [Test]
        public void Test()
        {
            var strings=new UniqueCollection<string>();
            
            strings.Add("string1");
    
            Assert.Throws<ArgumentException>(() => strings.Add("string1"));
        }
    }
}