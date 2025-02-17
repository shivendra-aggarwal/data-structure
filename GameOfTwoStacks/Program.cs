// See https://aka.ms/new-console-template for more information



//static int twoStacks(int maxSum, List<int> a, List<int> b)
//{
//    if (!a.Any() && !b.Any())
//    {
//        return 0;
//    }

//    a.Reverse();
//    b.Reverse();
//    int moveCount = 0, localSum = 0;

//    Stack<int> stackA = new Stack<int>();
//    Stack<int> stackB = new Stack<int>();

//    foreach (var i in a)
//    {
//        stackA.Push(i);
//    }

//    foreach (var i in b)
//    {
//        stackB.Push(i);
//    }

//    while (localSum <= maxSum)
//    {
//        if (stackA.Count > 0 && stackB.Count > 0
//            && stackA.Peek() < stackB.Peek())
//        {
//            localSum += stackA.Pop();
//            moveCount++;
//        }
//        else if (stackB.Count > 0)
//        {
//            localSum += stackB.Pop();
//            moveCount++;
//        }
//        else if (stackA.Count > 0)
//        {
//            localSum += stackA.Pop();
//            moveCount++;
//        }
//        else if(stackA.Count == 0 && stackB.Count == 0)
//        {
//            return moveCount;
//        }
//    }

//    return localSum > maxSum ? --moveCount : moveCount;

//}

static int twoStacks(int maxSum, List<int> a, List<int> b)
{
    if (!a.Any() && !b.Any())
    {
        return 0;
    }

    int i = 0, j = 0, moveCount = 0;
    long sum = 0;
    while (i < a.Count && sum + a[i] < maxSum)
    {
        sum += a[i];
        i += 1;
    }
    moveCount = i;

    while (j < b.Count && i > 0)
    {
        sum += b[j];
        j += 1;

        while (i > 0 && sum > maxSum)
        {
            sum -= a[i-1];
            i -= 1;
        }
        moveCount = (sum <= maxSum) ? Math.Max((i + j), moveCount) : moveCount;
    }

    

    return moveCount;
}


//Console.WriteLine(twoStacks(10, new List<int>() { 4, 2, 4, 6, 1 }, new List<int>() { 2, 1, 8, 5 }));
Console.WriteLine(twoStacks(40, new List<int>() { 5, 5, 20, 5 }, new List<int>() { 5, 15, 30 }));
//Console.WriteLine(twoStacks(12, new List<int>() { 1, 2, 3, 4, 5 }, new List<int>() { 6, 7, 8, 9 }));