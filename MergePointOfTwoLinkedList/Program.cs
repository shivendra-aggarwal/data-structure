// See https://aka.ms/new-console-template for more information
using MergePointOfTwoLinkedList;



static int findMergeNode(Node head1, Node head2)
{
    HashSet<Node> visited = new HashSet<Node>();
    Node p, p1;
    p = head1;
    p1 = head2;

    while(p != null)
    {
        visited.Add(p);
        p = p.next;
    }

    while (p1 != null)
    {
        if(visited.Contains(p1))
        {
            return p1.data;
        }

        p1 = p1.next;
    }

    return -1;
}

Node head1 = new Node(1);
Node head = new Node(1);
head.next = new Node(2);
head.next.next = new Node(3);
head1.next = new Node(2);
head1.next.next = new Node(3);
head1.next.next.next = new Node(44);
head.next.next.next = head1.next.next.next;
head.next.next.next.next = new Node(5);


head1.next.next.next.next = new Node(5);
Console.WriteLine(findMergeNode(head, head1));