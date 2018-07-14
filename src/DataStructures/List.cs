using System;
using System.Linq;

namespace DataStructures
{
    /// <summary>
    /// List is an abstract data structure that can contain n amount of elements.
    /// A List behaves much like an array, but without a fixed size.
    /// Lists are initialised with a size, and dynamically changes as needed to
    /// accomodate more element. Whenever an elements gets appended to a
    /// list that goes beyond the current size, the size is multiplied by two.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class List<T>
    {
        private int _capacity;
        private int _index;
        private int _count;
        private T[] _items;

        public List(int capacity = 8)
        {
            _capacity = capacity;
            _items = new T[_capacity];
        }

        public void AddItem(T item)
        {
            MaybeIncreaseCapacity();
            _items[_index++] = item;
            _count++;
        }

        public T this[int index]
        {
            get => Get(index);
            set => SetOrReplace(index, value);
        }

        public int Count => _count;

        private T Get(int index)
        {
            if (index +1 > _count)
                throw new IndexOutOfRangeException();

            return _items[index];
        }

        private void SetOrReplace(int index, T item)
        {
            if (index == _items.Length)
                AddItem(item);

            if (index > _items.Length)
                throw new IndexOutOfRangeException();

            _items[index] = item;
        }

        private void MaybeIncreaseCapacity()
        {
            if (_count >= _capacity)
            {
                var tmp = _items;
                _capacity = _capacity * 2;
                _items = new T[_capacity];

                for (var i = 0; i < tmp.Length; i++)
                {
                    _items[i] = tmp[i];
                }
            }
        }
    }
}
