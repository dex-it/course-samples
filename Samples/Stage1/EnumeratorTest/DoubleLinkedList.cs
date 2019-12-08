using System;
using System.Collections;
using System.Collections.Generic;

namespace Stage1.EnumeratorTest
{
    public class DoubleLinkedList<T> : IEnumerator<Node<T>>, IEnumerable<T>
    {
        private Node<T> _first;
        private Node<T> _last;
        private Node<T> _current;
        private int _count { get; set; }

        public bool Add(T data)
        {
            if (data == null)
            {
                return false;
            }

            var node = new Node<T>(data);

            if (_count == 0)
            {
                _first = node;
                _last = node;
            }
            else
            {
                _last.Next = node;
                node.Previous = _last;
            }

            _last = node;

            _count++;

            return true;
        }

        public bool Remove(T data)
        {
            _current = Find(data);

            if (_current == null) return false;

            if (_current.Previous != null && _current.Next != null)
            {
                _current.Previous.Next = _current.Next;
                _current.Next.Previous = _current.Previous;
                return true;
            }

            if (_current.Previous == null)
            {
                _first = _current.Next;
                _current.Previous = null;
                return true;
            }


            if (_current.Next == null)
            {
                _last = _current.Previous;
                return true;
            }

            _count--;
            return true;
        }

        public Node<T> Find(T data)
        {
            if (_count == 0) return null;

            var current = _first;

            while (current != null)
            {
                if (current.Value.Equals(data))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }


        public bool MoveNext()
        {
            if (_count == 0) return false;

            if (_current == null)
            {
                _current = _first;
                return true;
            }

            if (_current.Next == null)
            {
                return false;
            }

            _current = _current.Next;
            return true;
        }

        public bool MovePrevious()
        {
            if (_count == 0) return false;

            if (_current == null)
            {
                _current = _last;
                return true;
            }


            if (_current.Previous == null)
            {
                return false;
            }

            _current = _current.Previous;
            return true;
        }

        public void Reset()
        {
            _current = _first;
        }

        public Node<T> Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            if (_first==null)
            {
                return;
            }

            while (MoveNext())
            {
                _current = null;
            }

            ;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) this).GetEnumerator();
        }

       IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = _first;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
       
    }
}