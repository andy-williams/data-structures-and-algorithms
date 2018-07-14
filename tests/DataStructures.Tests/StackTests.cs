using Xunit;

namespace DataStructures.Tests
{
    public class StackTests
    {
        private readonly Stack<int> _stack;

        public StackTests()
        {
            _stack = new Stack<int>();
        }

        [Fact]
        public void ItStacksItems()
        {
            _stack.Push(1);
            _stack.Push(2);

            Assert.Equal(2, _stack.Pop());
            Assert.Equal(1, _stack.Pop());
        }
    }
}
