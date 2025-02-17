// See https://aka.ms/new-console-template for more information

using CycleLinkedList;

static bool hasCycle(Node node)
{
    bool hasCycle = false;
    HashSet<Node> visited = new HashSet<Node>();
    Node p = node;
    while (p != null)
    {
        if(visited.Contains(p))
        {
            return true;
        }
        visited.Add(p);
        p = p.next;
    }

    return hasCycle;
}

Node head = new Node(3);
head.next = new Node(2);
head.next.next = new Node(1);
head.next.next.next = head.next;
//head.next.next.next.next = new Node(5);
Console.WriteLine(hasCycle(head));