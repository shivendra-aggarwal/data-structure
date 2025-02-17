using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoList
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }
}
