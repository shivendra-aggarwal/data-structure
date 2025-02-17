// See https://aka.ms/new-console-template for more information
using RemoveDuplicateNodeValues;

static Node removeDuplicates(Node llist)
{
    Node p = llist;
    Node temp = null;

    while (p != null)
    {
        temp = p.next;
        if (temp != null && p.data == temp.data)
        {
            temp = temp.next;
            p.next = temp;
        }
        else
        {
            p = p.next;
        }
    }
    return llist;
}




Node head = new Node(1);
head.next = new Node(1);
head.next.next = new Node(2);
head.next.next.next = new Node(2);
head.next.next.next.next = new Node(3);
head.next.next.next.next.next = new Node(3);
head.next.next.next.next.next.next = new Node(3);
head.next.next.next.next.next.next.next = new Node(5);

var reversedHead = removeDuplicates(head);

while (reversedHead != null)
{
    Console.WriteLine(reversedHead.data);
    reversedHead = reversedHead.next;
}