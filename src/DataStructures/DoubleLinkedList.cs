using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace DataStructures
{
    public interface ILinkedList<T>
    {
        void AddItem(T item);
        void RemoveAt(int index);
        int Length { get; }
        T this[int index] { get; set; }
    }

    public class DoubleLinkedList<T> : ILinkedList<T>
    {
        private int _length;
        private Node<T> _root;
        private Node<T> _last;

        public void AddItem(T item)
        {
            var newItem = new Node<T>(item);
            if (_root == null)
            {
                _root = newItem;
            }
            else
            {
                _root.Next = newItem;
                newItem.Previous = _last;
            }

            _length++;
            _last = newItem;
        }

        public void RemoveAt(int index)
        {
            // todo: validate
            var node = GetNode(index);
            RemoveNode(node);
        }

        private Node<T> GetNode(int index)
        {
            var currentNode = _root;

            if (index == 0)
                return currentNode;

            for (var i = 1; i < index; i++)
                currentNode = currentNode.Next;

            return currentNode;
        }

        private void RemoveNode(Node<T> node)
        {
            var previous = node.Previous;
            var next = node.Next;
            node.Next = null;
            node.Previous = null;

            previous.Next = next;
            next.Previous = previous;

            if (node == _root)
                _root = node.Next;

            if (node == _last && _root != _last)
                _last = node.Previous;

            _length--;
        }

        public int Length => _length;

        public T this[int index]
        {
            get => GetNode(index).Value;
            set => GetNode(index).Value = value;
        }

        private class Node<T>
        {
            private T _value;

            public Node(T value)
            {
                _value = value;
            }

            public T Value
            {
                get => _value;
                set => _value = value;
            }

            public Node<T> Next { get; set; }
            public Node<T> Previous { get; set; }
        }
    }

    
}
