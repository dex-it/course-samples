using System;
using System.Collections;
using System.Collections.Generic;

namespace Stage1.EnumeratorTest
{
    internal class DoubleLinkedListEnumerator<T> : IEnumerator<Node<T>>
    {
        public DoubleLinkedListEnumerator(DoubleLinkedList<T> doubleLinkedList)
        {
            _doubleLinkedList = doubleLinkedList;
            _doubleLinkedList.Current = null;
        }


        private DoubleLinkedList<T> _doubleLinkedList;

        object IEnumerator.Current => Current;

        public Node<T> Current
        {
            get => _doubleLinkedList.Current;
            set => _doubleLinkedList.Current = value;
        }

        public void Dispose()
        {
            _doubleLinkedList = null;
        }

        public bool MoveNext()
        {
            if (_doubleLinkedList.Count == 0) return false;

            if (Current == null)
            {
                Current = _doubleLinkedList.First;
                return true;
            }

            if (Current.Next == null) return false;

            Current = Current.Next;
            return true;
        }

        public bool MovePrevious()
        {
            if (_doubleLinkedList.Count == 0) return false;

            if (Current == null)
            {
                Current = _doubleLinkedList.Last;
                return true;
            }

            if (Current.Previous == null) return false;

            Current = Current.Previous;
            return true;
        }

        public void Reset()
        {
            Current = null;
        }
    }
}
