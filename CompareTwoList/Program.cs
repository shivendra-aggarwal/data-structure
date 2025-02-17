// See https://aka.ms/new-console-template for more information
using CompareTwoList;

static int CompareLists(Node head, Node head1)
{
    int result = 1;
    var p = head;
    var p1 = head1;
    while (p != null || p1 != null)
    {
        if (p?.data != p1?.data)
        {
            result = 0;
            return result;
        }
        else
        {
            p = p.next;
            p1 = p1.next;
        }
    }
    return result;
}



Node head = new Node(1);
head.next = new Node(2);
head.next.next = new Node(3);
head.next.next.next = new Node(4);
head.next.next.next.next = new Node(5);
Node head1 = new Node(1);
head1.next = new Node(2);
head1.next.next = new Node(3);
head1.next.next.next = new Node(4);
head1.next.next.next.next = new Node(5);
Console.WriteLine(CompareLists(head, head1));