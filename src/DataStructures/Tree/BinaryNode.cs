using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tree
{
    public class BinaryNode<T>
    {
        private T _value;
        private BinaryNode<T> _left;
        private BinaryNode<T> _right;

        public BinaryNode(T value)
        {
            _value = value;
        }

        public T Value
        {
            get => _value;
            set => _value = value;
        }

        public BinaryNode<T> Left
        {
            get => _left;
            set => _left = value;
        }

        public BinaryNode<T> Right
        {
            get => _right;
            set => _right = value;
        }
    }
}
