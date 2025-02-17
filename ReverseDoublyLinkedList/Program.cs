// See https://aka.ms/new-console-template for more information
using ReverseDoublyLinkedList;

static DoublyNode reverse(DoublyNode llist)
{
    DoublyNode p = llist;
    DoublyNode temp = null;
    while (p != null)
    {
        temp = p.next;
        p.next = p.prev;
        p.prev = temp;
        
        if(p.prev == null)
        {
            return p;
        }
        else
        {
            p = p.prev;
        }

    }

    return llist;

}


DoublyNode head = new DoublyNode(1);
head.next = new DoublyNode(2);
head.next.prev = head;
head.next.next = new DoublyNode(3);
head.next.next.prev = head.next;
head.next.next.next = new DoublyNode(4);
head.next.next.next.prev = head.next.next;

DoublyNode new_head = reverse(head);

while (new_head != null)
{
    Console.WriteLine(new_head.data);
    new_head = new_head.next;
}