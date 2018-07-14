using System.Linq;
using Algorithms;
using DataStructures.Tree;
using Xunit;

namespace AlgorithmsTests
{
    public class TraversalTests
    {
        [Fact]
        public void BreadthDepthTraversesLeftToRight()
        {
            //
            //       1
            //      / \
            //     2   3
            //    / \   \
            //   4   5   6
            //

            var a = new BinaryNode<int>(1);
            a.Left = new BinaryNode<int>(2);
            a.Right = new BinaryNode<int>(3);

            a.Right.Right = new BinaryNode<int>(6);

            a.Left.Left = new BinaryNode<int>(4);
            a.Left.Right = new BinaryNode<int>(5);

            Assert.Equal(1, a.Value);

            var results = a.BreadthFirst();
            var enumerator = results.GetEnumerator();

            Assert.Equal(6, results.Count());

            var i = 1;
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Assert.Equal(i++, item);
            }
        }

        [Fact]
        public void DepthFirstTraversesLeftDownThenBackUp()
        {
            //
            //       1
            //      / \
            //     2   5
            //    / \   \
            //   3   4   6
            //

            var a = new BinaryNode<int>(1);
            a.Left = new BinaryNode<int>(2);
            a.Right = new BinaryNode<int>(5);

            a.Right.Right = new BinaryNode<int>(6);

            a.Left.Left = new BinaryNode<int>(3);
            a.Left.Right = new BinaryNode<int>(4);

            Assert.Equal(1, a.Value);

            var results = a.DepthFirst();
            var enumerator = results.GetEnumerator();

            Assert.Equal(6, results.Count());

            var i = 1;
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Assert.Equal(i++, item);
            }
        }
    }
}
