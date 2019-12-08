using System;
using System.Runtime.InteropServices;
using System.Threading;
using NUnit.Framework;

namespace Stage1.EnumeratorTest
{
    public class DoubleLinkedListTest
    {
        [Test]
        public void Test()
        {
            var list = new DoubleLinkedList<string>
            {
                "first",
                "second",
                "third"
            };

            foreach (var item in list)
            { 
                Console.WriteLine(item);
            }

            while (list.MovePrevious())
            {
                Console.WriteLine(list.Current.Value);
            }
            
        }
        
        
    }
}