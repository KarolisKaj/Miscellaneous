using System.Diagnostics;

namespace LowestCommonAncestor
{
    [DebuggerDisplay("Value = {Value}, Nodes count = {Leafs.Length}")]
    public class Node<T>
    {
        public Node(Node<T>[] leafs, T value)
        {
            Leafs = leafs;
            Value = value;
        }
        public Node<T>[] Leafs { get; }
        public T Value { get; }
    }
}