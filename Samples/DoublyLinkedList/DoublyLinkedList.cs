using System;
using System.Collections;

namespace DoublyLinkedList
{
    public class DoublyLinkedList : IEnumerable
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        private int count = 0;

        public void AddToBegin(int value)
        {
            Node node = new Node(value);
            Node temp = Head;
            node.Next = temp;
            Head = node;

            if (count == 0)
                Tail = Head;
            else
                temp.Previous = node;
            count++;
        }

        public void AddToEnd(int value)
        {
            Node node = new Node(value);

            if (Head == null)
                Head = node;
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;
            count++;
        }

        public IEnumerator GetEnumerator()
        {
            return new ListEnumerator(this);
        }
    }
}