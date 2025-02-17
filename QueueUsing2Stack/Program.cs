// See https://aka.ms/new-console-template for more information
static void processQuery()
{
    int q = int.Parse(Console.ReadLine());
    Stack<int> stackA = new Stack<int>();
    Stack<int> stackB = new Stack<int>();

    for (int i = 0; i < q; i++)
    {
        string[] query = Console.ReadLine().Split(" ");
        switch (query[0])
        {
            case "1":
                stackA.Push(int.Parse(query[1]));
                break;
            case "2":
                if (stackB.Count == 0)
                {
                    while (stackA.Count > 0)
                    {
                        stackB.Push(stackA.Pop());
                    }
                    stackB.Pop();
                }
                else
                {
                    stackB.Pop();
                }
                break;
            case "3":
                if (stackB.Count == 0)
                {
                    while (stackA.Count > 0)
                    {
                        stackB.Push(stackA.Pop());
                    }
                    Console.WriteLine(stackB.Peek());
                }
                else
                {
                    Console.WriteLine(stackB.Peek());
                }
                break;
        }
    }
}

processQuery();