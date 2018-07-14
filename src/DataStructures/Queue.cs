namespace DataStructures
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
        bool IsEmpty();
    }

    public class Queue<T> : IQueue<T>
    {
        private ILinkedList<T> _list = new DoubleLinkedList<T>();

        public void Enqueue(T item)
        {
            // O(1)
            _list.AddItem(item);
        }

        public T Dequeue()
        {
            // O(1)
            var item = _list[0];
            _list.RemoveAt(0);
            return item;
        }

        public bool IsEmpty()
        {
            return _list.Length == 0;
        }
    }
}
