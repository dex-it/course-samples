using System.Collections;
using System.Collections.Generic;

namespace Stage1.EnumeratorTest
{
    public class DoubleLinkedList<T> : IEnumerable<Node<T>>
    {
        public Node<T> First;
        public Node<T> Last;
        public Node<T> Current;
        public int Count { get; set; }

        public bool Add(T data)
        {
            if (data == null) return false;

            var node = new Node<T>(data);

            if (Count == 0)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                node.Previous = Last;
            }

            Last = node;

            Count++;

            return true;
        }

        public bool Remove(T data)
        {
            Current = Find(data);

            if (Current == null) return false;

            if (Current.Previous != null && Current.Next != null)
            {
                Current.Previous.Next = Current.Next;
                Current.Next.Previous = Current.Previous;
                return true;
            }

            if (Current.Previous == null)
            {
                First = Current.Next;
                Current.Previous = null;
                return true;
            }


            if (Current.Next == null)
            {
                Last = Current.Previous;
                return true;
            }

            Count--;
            return true;
        }

        public Node<T> Find(T data)
        {
            if (Count == 0) return null;

            var current = First;

            while (current != null)
            {
                if (current.Value.Equals(data)) return current;

                current = current.Next;
            }

            return null;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) this).GetEnumerator();
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            return new DoubleLinkedListEnumerator<T>(this);
        }

    }
}