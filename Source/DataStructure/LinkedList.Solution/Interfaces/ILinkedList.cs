using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Solution.Interfaces
{
    public interface ILinkedList<T> where T : class
    {
        T Head { get; }

        T Tail { get; }

        int Count { get; }

        void Add(T node);

        void Remove(T node);

        T Find(int value);

        
    }
}
