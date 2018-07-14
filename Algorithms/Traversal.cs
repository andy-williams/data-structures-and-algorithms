using System;
using System.Collections.Generic;
using DataStructures;
using DataStructures.Tree;

namespace Algorithms
{
    public static class BinaryTreeTraversals
    {
        public static IEnumerable<T> BreadthFirst<T>(this BinaryNode<T> node)
        {
            var queue = new DataStructures.Queue<BinaryNode<T>>();
            queue.Enqueue(node);

            while (!queue.IsEmpty())
            {
                var currentNode = queue.Dequeue();
                if(currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);

                if(currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);

                yield return currentNode.Value;
            }
        }

        public static IEnumerable<T> DepthFirst<T>(this BinaryNode<T> node)
        {
            yield return node.Value;
            var leftItems = node.Left?.DepthFirst();
            var rightItems = node.Right?.DepthFirst();

            if (leftItems != null)
            {
                foreach (var item in leftItems)
                    yield return item;
            }

            if (rightItems != null)
            {
                foreach (var item in rightItems)
                    yield return item;
            }
        }
        
    }
}
