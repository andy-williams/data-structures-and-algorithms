using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests
{
    public class DoubleLinkedListTests
    {
        private DoubleLinkedList<int> _list;

        public DoubleLinkedListTests()
        {
            _list = new DoubleLinkedList<int>();
        }

        [Fact]
        public void ItAddsItems()
        {
            _list.AddItem(1);
            _list.AddItem(2);

            Assert.Equal(1, _list[0]);
            Assert.Equal(2, _list[1]);
            Assert.Equal(2, _list.Length);

            _list.RemoveAt(0);
            Assert.Equal(2, _list[0]);
            Assert.Equal(1, _list.Length);
        }
    }
}
