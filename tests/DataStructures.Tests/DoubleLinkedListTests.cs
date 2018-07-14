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
            _list.AddItem(3);
            _list.AddItem(4);

            Assert.Equal(1, _list[0]);
            Assert.Equal(2, _list[1]);
            Assert.Equal(4, _list[_list.Length - 1]);
            Assert.Equal(4, _list.Length);

            _list.RemoveAt(0);
            Assert.Equal(2, _list[0]);
            Assert.Equal(3, _list.Length);

            _list.RemoveAt(2);
            _list.RemoveAt(0);
            _list.RemoveAt(0);
            Assert.Equal(0, _list.Length);
        }
    }
}
