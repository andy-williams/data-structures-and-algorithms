using System;
using System.Collections.Generic;
using System.Text;
using Algorithms;
using Xunit;

namespace AlgorithmsTests
{
    public class SortTests
    {
        private IList<int> _testList;
        private IList<int> _sorted;

        public SortTests()
        {
            _testList = new List<int>
            {
                1,5,3,2,6,8,10,6,5
            };

            _sorted = new List<int>
            {
                1,2,3,5,5,6,6,8,10
            };
        }

        [Fact]
        public void QuickSort()
        {
            var sortedResult = _testList.QuickSort();

            Assert.Equal(_sorted[0], sortedResult[0]);
            Assert.Equal(_sorted[1], sortedResult[1]);
            Assert.Equal(_sorted[2], sortedResult[2]);
            Assert.Equal(_sorted[3], sortedResult[3]);
            Assert.Equal(_sorted[4], sortedResult[4]);
            Assert.Equal(_sorted[5], sortedResult[5]);
            Assert.Equal(_sorted[6], sortedResult[6]);
            Assert.Equal(_sorted[7], sortedResult[7]);
            Assert.Equal(_sorted[8], sortedResult[8]);
            Assert.Equal(_sorted[9], sortedResult[9]);

        }
    }
}
