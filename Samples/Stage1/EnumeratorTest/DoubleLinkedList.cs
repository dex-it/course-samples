using System.Collections;
using System.Collections.Generic;

namespace Stage1.EnumeratorTest
{
    public class DoubleLinkedList<T> : IEnumerator<Node<T>>, IEnumerable<T>
    {
        private Node<T> first;
        private Node<T> last;
        private Node<T> current;
        private int count { get; set; }

        public bool Add(T data)
        {
            if (data == null)
            {
                return false;
            }

            Node<T> node = new Node<T>(data);

            if (count == 0)
            {
                first = node;
                last = node;
            }
            else
            {
                last.Next = node;
                node.Previous = last;
            }

            last = node;

            count++;

            return true;
        }

        public bool Remove(T data)
        {
            current = Find(data);

            if (current == null) return false;

            if (current.Previous != null && current.Next != null)
            {
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
                return true;
            }

            if (current.Previous == null)
            {
                first = current.Next;
                current.Previous = null;
                return true;
            }


            if (current.Next == null)
            {
                last = current.Previous;
                return true;
            }

            count--;
            return true;
        }

        public Node<T> Find(T data)
        {
            if (count == 0) return null;

            var current = first;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }


        public bool MoveNext()
        {
            if (count == 0) return false;

            if (current == null)
            {
                current = first;
                return true;
            }

            if (current.Next == null)
            {
                return false;
            }

            current = current.Next;
            return true;
        }

        public bool MovePrevious()
        {
            if (count == 0) return false;

            if (current == null)
            {
                current = last;
                return true;
            }


            if (current.Previous == null)
            {
                return false;
            }

            current = current.Previous;
            return true;
        }

        public void Reset()
        {
            current = first;
        }

        public Node<T> Current => current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = first;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}