using System.Collections;

namespace DoublyLinkedList
{
    public class ListEnumerator : IEnumerator
    {
        private DoublyLinkedList list;
        private Node currentNode;

        public ListEnumerator(DoublyLinkedList list)
        {
            this.list = list;
            currentNode = null;
        }

        public object Current => currentNode.Value;

        public bool MoveNext()
        {
            currentNode = currentNode == null ? list.Head : currentNode.Next;

            return currentNode != null;
        }

        public void Reset()
        {
            currentNode = null;
        }
    }
}