using System;
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

            foreach (var item in list) Console.WriteLine(item.Value);


            using var listEnumerator = list.GetEnumerator() as DoubleLinkedListEnumerator<string>;


            while (listEnumerator.MovePrevious()) Console.WriteLine(list.Current.Value);

            listEnumerator.Reset();



            while (listEnumerator.MoveNext()) Console.WriteLine(list.Current.Value);


            listEnumerator.Reset();
        }
    }
}