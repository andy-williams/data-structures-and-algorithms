namespace DataStructures
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        T Seek();
    }

    public class Stack<T> : IStack<T>
    {
        private ILinkedList<T> _list = new DoubleLinkedList<T>();

        public void Push(T item)
        {
            // O(1)
            _list.AddItem(item);
        }

        public T Pop()
        {
            // O(1)
            var index = _list.Length - 1;
            var item = _list[index];
            _list.RemoveAt(index);

            return item;
        }

        public T Seek()
        {
            // O(1)
            var index = _list.Length - 1;
            var item = _list[index];

            return item;
        }
    }
}
