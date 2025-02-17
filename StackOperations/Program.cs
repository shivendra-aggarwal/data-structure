// See https://aka.ms/new-console-template for more information
using StackOperations;


static List<int> getMax(List<string> operations)
{
    List<int> max = new List<int>();
    MyStack myStack = new MyStack();
    foreach (var operation in operations)
    {
        switch (operation.Split(" ")[0])
        {
            case "1":
                int value = int.Parse(operation.Split(" ")[1]);
                myStack.Push(value);
                break;
            case "2":
                myStack.Pop();
                break;
            case "3":
                max.Add(myStack.max);
                break;
        }
    }

    return max;
}

var results = getMax(new List<string>() { "1 97", "2", "1 20", "2", "1 26", "1 20", "2", "3", "1 91", "3" });


foreach (var res in results)
{
    Console.WriteLine(res);
}
