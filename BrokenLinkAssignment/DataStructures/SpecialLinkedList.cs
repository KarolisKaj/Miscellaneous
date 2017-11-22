using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public int Index { get; set; }
    }

    // Implement linked list datastructure and all missing members for it
    public class SpecialLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private int _count = 0;

        public T Head
        {
            get
            {
                if (_head == null) return default(T);
                return _head.Value;
            }
        }

        public int Count => _count;

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerable(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerable(_head);
        }

        public void Add(T item)
        {
            _count++;
            if (_head == null)
            {
                _head = new Node<T> { Value = item, Index = 0 };
                return;
            }
            GetLast(_head).Next = new Node<T> { Value = item, Index = _count - 1 };
        }

        private Node<T> GetLast(Node<T> passedInNode)
        {
            if (passedInNode.Next == null) return passedInNode;
            return GetLast(passedInNode.Next);
        }

        public void Remove(T item)
        {
            if (_head == null) return;
            if (Equals(_head.Value, item))
            {
                _head = null;
                _count--;
                return;
            }

            var previousNode = MatchNode(item, _head);
            if (previousNode == null) return;

            previousNode.Next = previousNode.Next.Next;
            _count--;
        }

        private Node<T> MatchNode(T match, Node<T> previousNode)
        {
            if (previousNode.Next == null) return null;
            if (Equals(previousNode.Next.Value, match)) return previousNode;
            return previousNode.Next;
        }

        public void RemoveAt(int index)
        {
            if (0 > index || index >= _count || _head == null)
                throw new IndexOutOfRangeException();

            if (index == 0)
            {
                _head = null;
                _count--;
                return;
            }

            var nodeChildToRemove = GetPrentNodeIndexOf(index, _head);
            nodeChildToRemove.Next = nodeChildToRemove.Next?.Next;
            _count--;
        }

        private Node<T> GetPrentNodeIndexOf(int index, Node<T> parentNode)
        {
            if (parentNode.Next.Index == index) return parentNode;
            return parentNode.Next;
        }

        public override string ToString()
        {
            if (_head == null) return String.Empty;

            return GetValues(_head, new StringBuilder()).TrimEnd(new char[] { ',' });
        }

        private string GetValues(Node<T> node, StringBuilder sb)
        {
            if (node == null) return sb.ToString();
            if (node.Value == null) GetValues(node.Next, sb);
            sb.Append(node.Value?.ToString()); sb.Append(",");
            return GetValues(node.Next, sb);
        }

        public string ToStringReverse()
        {
            if (_head == null) return String.Empty;

            return GetValuesReverse(_head, new StringBuilder()).TrimEnd(new char[] { ',' });
        }

        private string GetValuesReverse(Node<T> node, StringBuilder sb)
        {
            if (node == null) return sb.ToString();
            if (node.Value == null) GetValuesReverse(node.Next, sb);
            GetValuesReverse(node.Next, sb);
            sb.Append(node.Value?.ToString()); sb.Append(",");
            return sb.ToString();
        }
        public T this[int index]
        {
            get
            {
                if (0 > index || index >= _count)
                    throw new IndexOutOfRangeException();

                if (index == 0) return Head;

                return GetPrentNodeIndexOf(index, _head).Next.Value;
            }
            set
            {
                if (0 > index || index >= _count)
                    throw new IndexOutOfRangeException();

                if (index == 0)
                {
                    _head.Value = value;
                    return;
                }

                GetPrentNodeIndexOf(index, _head).Next.Value = value;
            }
        }

        private class Enumerable : IEnumerator<T>
        {
            private Node<T> _current;
            private readonly Node<T> _startNode;

            public Enumerable(Node<T> startNode)
            {
                _startNode = startNode;
                _current = _startNode;
            }
            public T Current => _current.Value;

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                _current = _current.Next;
                return _current.Next != null;
            }

            public void Reset() => _current = _startNode;
        }
    }
}
