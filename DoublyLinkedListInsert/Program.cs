// See https://aka.ms/new-console-template for more information
using DoublyLinkedListInsert;


static DoublyNode sortedInsert(DoublyNode llist, int data)
{
    DoublyNode p = llist;
    DoublyNode n = new DoublyNode(data);
    
    while(p != null)
    {
        if(n.data <= p.data && p.prev != null)
        {
            p.prev.next = n;
            n.prev = p.prev;
            n.next = p;
            p.prev = n;
            return llist;
        }
        else if (n.data <= p.data && p.prev == null)
        {
            p.prev = n;
            n.next = p;
            return n;
        }
        else if(p.data <= n.data && p.next == null)
        {
            p.next = n;
            n.prev = p;
            return llist;
        }
        p = p.next;
    }

    return llist;
}


DoublyNode head = new DoublyNode(1);
head.next = new DoublyNode(2);
head.next.prev = head;
head.next.next = new DoublyNode(3);
head.next.next.prev = head.next;

DoublyNode new_p = sortedInsert(head, 4);

while(new_p != null)
{
    Console.WriteLine(new_p.data);
    new_p = new_p.next;
}
//head.next.next.next = new DoublyNode(4);
//head.next.next.prev = head.next.next;
//head.next.next.next.next = new DoublyNode(5);