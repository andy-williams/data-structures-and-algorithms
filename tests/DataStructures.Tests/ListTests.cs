using Xunit;

namespace DataStructures.Tests
{
    public class ListTests
    {
        private readonly List<int> _myList;

        public ListTests()
        {
            _myList = new List<int>();
        }

        [Fact]
        public void ItCanAdd()
        {
            _myList.AddItem(1);
            Assert.Equal(1, _myList[0]);
            Assert.Equal(1, _myList.Count);
        }
    }
}
