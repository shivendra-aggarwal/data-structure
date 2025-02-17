using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDoublyLinkedList
{
    internal class DoublyNode
    {
        public int data;
        public DoublyNode next;
        public DoublyNode prev;

        public DoublyNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.prev = null;

        }
    }
}
