using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace _12___UniqueCollection
{
    public class UniqueCollection<T>
    {
        private Collection<T> _collection;
        public UniqueCollection()
        {
            _collection = new Collection<T>();
        }
        public void Add(T item)
        {
            int k = 0;
            if (_collection.Contains(item))
                throw new Exception("Ошибка! Такое значение уже есть в коллекции!");
            else
            {
                _collection.Add(item);
            }
        }

        public int Length
        {
            get { return _collection.Count(); }
        }
            

        public void Display()
        {
            foreach (var c in _collection)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var U = new UniqueCollection<string>();
            try
            {                
                U.Add("один");
                U.Add("два");
                U.Add("три");
                U.Add("два");
                U.Add("один");
            }
            catch (Exception any)
            {
                Console.WriteLine(any.Message);
            }
            finally
            {
                U.Display();
            }
            Console.Read();


        }
    }
}
