using ReverseLinkedList;

static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
{
    SinglyLinkedListNode r = null, q = null, p = llist;
    
    while (p != null)
    {
        r = q;
        q = p;
        p = p.next;
        q.next = r;
    }

    return q;
}

SinglyLinkedListNode head = new SinglyLinkedListNode(1);
head.next = new SinglyLinkedListNode(2);
head.next.next = new SinglyLinkedListNode(3);
head.next.next.next = new SinglyLinkedListNode(4);
head.next.next.next.next = new SinglyLinkedListNode(5);
var reversedHead = reverse(head);

while(reversedHead != null)
{
    Console.WriteLine(reversedHead.data);
    reversedHead = reversedHead.next;
}