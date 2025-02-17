// See https://aka.ms/new-console-template for more information
using MergeSortedLinkedList;


static Node mergeLists(Node head1, Node head2)
{
    Node third_start, last = null;
    if (head1.data < head2.data)
    {
        third_start = last = head1;
        head1 = head1.next;
        last.next = null;
    }
    else
    {
        third_start = last = head2;
        head2 = head2.next;
        last.next = null;
    }

    while (head1 != null && head2 != null)
    {
        if (head1.data < head2.data)
        {
            last.next = head1;
            last = head1;
            head1 = head1.next;
            last.next = null;
        }
        else
        {
            last.next = head2;
            last = head2;
            head2 = head2.next;
            last.next = null;
        }
    }

    if (head1 != null) last.next = head1;
    else last.next = head2;

    return third_start;
}

Node head = new Node(2);
head.next = new Node(4);
head.next.next = new Node(8);
head.next.next.next = new Node(11);
//head.next.next.next.next = new Node(5);
Node head1 = new Node(4);
head1.next = new Node(5);
head1.next.next = new Node(7);
head1.next.next.next = new Node(9);
head1.next.next.next.next = new Node(13);
//head1.next.next.next.next = new Node(5);

var third_list = mergeLists(head, head1);
while (third_list != null)
{
    Console.WriteLine(third_list.data);
    third_list = third_list.next;
}