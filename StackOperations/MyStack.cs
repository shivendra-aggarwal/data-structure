using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperations
{
    internal class MyStack
    {
        public Node TOP;
        public int size;
        public int max;
        
        public void Push(int data)
        {
            max = max < data ? data : max;
            Node node = new Node(data);
            node.next = TOP;
            TOP = node;
            size++;
        }

        public bool IsEmpty()
        {
            return TOP == null;
        }

        public int Pop()
        {
            int value = -1;
            if (TOP == null)
            {
                return value;
            }
            else
            {
                value = TOP.data;
                Node node = TOP.next;
                TOP = node;
                size--;
                max = Max();
            }
            return value;
        }

        public int Peek(int position)
        {
            int value = -1;
            int index = 0;
            Node p = TOP;
            if (TOP == null)
                return value;

            while (p != null && index < (position - 1))
            {
                p = p.next;
            }

            if (p == null)
            {
                return value;
            }
            else
            {
                return p.data;
            }
        }

        public int Max()
        {
            int max = -1;
            if (TOP == null)
            {
                return max;
            }
            else
            {
                Node p = TOP;
                while (p != null)
                {
                    max = max < p.data ? p.data : max;
                    p = p.next;
                }
            }

            return max;
        }
    }
}
