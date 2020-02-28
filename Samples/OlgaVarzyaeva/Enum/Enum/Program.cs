using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        public class Feline : IEnumerable
        {
            private Cat[] _feline;
            Cat[] data;
            public Feline(Cat[] cArray)
            {
                Length = cArray.Length;
                _feline = new Cat[cArray.Length];
                data = new Cat[cArray.Length];//данные для индексирования
                for (int i = 0; i < cArray.Length; i++)
                {
                    _feline[i] = cArray[i];
                    data[i] = cArray[i];
                }
                

            }
            //индексирование------------------------------------------------------------------
            public Cat this[int index]
            {
                get
                {
                    return data[index];
                }
                set
                {
                    data[index] = value;
                }
            }
            //индексирование----------------------------------------------------------------------     
            public int Length { get; private set; }
            // Implementation for the GetEnumerator method.
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public FelineEnum GetEnumerator()
            {
                return new FelineEnum(_feline);
            }
        }

        public class FelineEnum : IEnumerator
        {
            public Cat[] _feline;

            // Enumerators are positioned before the first element
            // until the first MoveNext() call.
            int position = -1;

            public FelineEnum(Cat[] list)
            {
                _feline = list;
            }

            public bool MoveNext()
            {
                position++;
                return (position < _feline.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public Cat Current
            {
                get
                {
                    try
                    {
                        return _feline[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

        public class Cat
        {
            private Cat() { }
            public Cat(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
        }


        static void Main(string[] args)
        {
            Cat[] felineArray = new Cat[]
            {
                new Cat("Murka"),
                new Cat("Snejok"),
                new Cat("Liza"),
                new Cat("Manya")
            };

            Feline felineList = new Feline(felineArray);
            Console.WriteLine("Обход при помощи foreach:");
            foreach (Cat cat in felineList)
                Console.WriteLine(cat.Name);

            //с помощью индексирования           
            Console.WriteLine("Обход при помощи while:");
            int i = 0;            
            while (i < felineList.Length)
            {
                Console.WriteLine(felineList[i].Name);
                i++;
            }
            Console.Read();

        }
    }
}
