using System;

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
        private Node<T> _head;
        private Node<T> _last;

        public void AddItem(T item)
        {
            var newItem = new Node<T>(item);
            if (_head == null)
            {
                _head = newItem;
            }
            else
            {
                _last.Next = newItem;
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
            var currentNode = _head;

            if(_length == 0)
                throw new IndexOutOfRangeException();

            if (index == 0)
                return currentNode;

            if (index == _length - 1)
                return _last;

            if (_length / index <= _length / 2)
            {
                for (var i = 1; i < _length; i++)
                {
                    currentNode = currentNode.Next;
                    if (i == index)
                        return currentNode;
                }
            }
            else
            {
                currentNode = _last;
                for (var i = _length - 2; i > 0; i--)
                {
                    currentNode = currentNode.Previous;
                    if (i == index)
                        return currentNode;
                }

            }

            return currentNode;
        }

        private void RemoveNode(Node<T> node)
        {
            var previous = node.Previous;
            var next = node.Next;

            if(previous != null)
                previous.Next = next;

            if(next != null)
                next.Previous = previous;

            if (node == _head)
                _head = node.Next;

            if (node == _last && _head != _last)
                _last = node.Previous;

            node.Next = null;
            node.Previous = null;

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
