using System;
using DataStructures;
using DataStructures.Tree;

namespace Algorithms
{
    public static class BinaryTreeTraversals
    {
        public static void BreadthFirst<T>(this BinaryNode<T> node, Action<BinaryNode<T>> action)
        {
            var queue = new Queue<BinaryNode<T>>();
            queue.Enqueue(node);

            while (!queue.IsEmpty())
            {
                var currentNode = queue.Dequeue();
                if(node.Left != null)
                    queue.Enqueue(currentNode.Left);

                if(node.Right != null)
                    queue.Enqueue(currentNode.Right);

                action(node);
            }
        }

        public static void DepthFirst<T>(this BinaryNode<T> node, Action<BinaryNode<T>> action)
        {
            action(node);
            node.Left?.DepthFirst(action);
            node.Right?.DepthFirst(action);
        }
        
    }
}
