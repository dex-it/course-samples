using System;

namespace DoublyLinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new DoublyLinkedList();
            list.AddToBegin(5);
            list.AddToEnd(10);
            list.AddToEnd(15);
            list.AddToBegin(0);
            list.AddToEnd(20);

            foreach (var node in list)
            {
                Console.WriteLine(node);
            }

            Console.ReadKey();
        }
    }
}