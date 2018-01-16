using DataStructure.Common;
using System;

namespace LinkedList.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node() { Value = 3 };

            Node middle = new Node() { Value = 5 };

            Node last = new Node() { Value = 7 };

            first.Next = middle;

            middle.Next = last;

            PrintList(first);

            System.Console.ReadLine();
        }

        private static void PrintList(Node first)
        {
            while (first != null)
            {
                System.Console.WriteLine(first.Value);
                first = first.Next;
            }
        }
    }
}
