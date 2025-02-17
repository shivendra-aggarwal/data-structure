// See https://aka.ms/new-console-template for more information
using GetNodeValue;

static int getNode1(Node llist, int positionFromTail)
{
    List<int> arr = new List<int>();
    Node p = llist;
    while (p != null)
    {
        arr.Add(p.data);
        p = p.next;
    }
    positionFromTail++;
    return arr[arr.Count - positionFromTail];
}

static int getNode2(Node llist, int positionFromTail)
{
    int i = 0, j = 0;
    Node p = llist;
    while (p != null)
    {
        i++;
        p = p.next;
    }

    p = llist;
    positionFromTail++;
    while (p != null)
    {
        if (j == (i - positionFromTail))
        {
            return p.data;
        }
        else
        {
            p = p.next;
            j++;
        }
    }
    return -1;

}



Node head = new Node(3);
head.next = new Node(2);
head.next.next = new Node(1);
head.next.next.next = new Node(0);
//head.next.next.next.next = new Node(5);
Console.WriteLine(getNode1(head, 1));
Console.WriteLine(getNode2(head, 1));