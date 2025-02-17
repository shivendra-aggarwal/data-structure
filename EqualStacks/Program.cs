// See https://aka.ms/new-console-template for more information


static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
{
    int h1_sum = 0, h2_sum = 0, h3_sum = 0;
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();
    Stack<int> stack3 = new Stack<int>();
    h1.Reverse();
    h2.Reverse();
    h3.Reverse();
    foreach (var i in h1)
    {
        stack1.Push(i);
    }
    foreach (var i in h2)
    {
        stack2.Push(i);
    }
    foreach (var i in h3)
    {
        stack3.Push(i);
    }
    
    h1_sum = stack1.Sum();
    h2_sum = stack2.Sum();
    h3_sum = stack3.Sum();

    while (h1_sum != h2_sum
        || h1_sum != h3_sum
        || h2_sum != h3_sum)
    {
        if (h1_sum > h2_sum || h1_sum > h3_sum)
        {
            h1_sum -= stack1.Pop();
        }
        else if (h2_sum > h3_sum || h2_sum > h1_sum)
        {
            h2_sum -= stack2.Pop();
        }
        else if (h3_sum > h1_sum || h3_sum > h2_sum)
        {
            h3_sum -= stack3.Pop();
        }
    }

    return h1_sum;
}


//Console.WriteLine(equalStacks(
//    new List<int>() { 3, 2, 1, 1, 1 },
//    new List<int>() { 4, 3, 2 },
//    new List<int>() { 1, 1, 4, 1 }));

Console.WriteLine(equalStacks(
    new List<int>() { 1, 2, 1, 1 },
    new List<int>() { 1, 1, 2 },
    new List<int>() { 1, 1 }));