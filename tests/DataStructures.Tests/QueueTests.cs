
using Xunit;

namespace DataStructures.Tests
{
    public class QueueTests
    {
        private readonly Queue<int> _queue;

        public QueueTests()
        {
            _queue = new Queue<int>();
        }

        [Fact]
        public void ItQueuesItems()
        {
            _queue.Enqueue(1);
            _queue.Enqueue(2);

            Assert.False(_queue.IsEmpty());

            Assert.Equal(1, _queue.Dequeue());

            _queue.Enqueue(3);
            _queue.Enqueue(4);
            _queue.Enqueue(5);

            Assert.Equal(2, _queue.Dequeue());
            Assert.Equal(3, _queue.Dequeue());
            Assert.Equal(4, _queue.Dequeue());

            Assert.True(!_queue.IsEmpty());

            Assert.Equal(5, _queue.Dequeue());

            Assert.True(_queue.IsEmpty());
        }
    }
}
