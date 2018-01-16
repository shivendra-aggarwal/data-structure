using System;
using System.Collections;
using System.Collections.Generic;
using LinkedList.Solution.Models;
using Model = LinkedList.Solution.Models;

namespace LinkedList.Solution
{
    public class LinkedList<T> :
        System.Collections.Generic.ICollection<T>
    {
        public Model.LinkedListNode<T> Head { get; private set; }

        public Model.LinkedListNode<T> Tail { get; private set; }

        public int Count { get; private set; }

        public bool IsReadOnly { get; set; }

        public void AddFirst(T value)
        {
            AddFirst(new Model.LinkedListNode<T>(value));
        }

        public void AddFirst(Model.LinkedListNode<T> node)
        {
            Model.LinkedListNode<T> temp = Head;

            Head = node;

            Head.Next = temp;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
