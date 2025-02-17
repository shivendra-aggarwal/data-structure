static int andXorOr(List<int> a)
{
    int maxResult = 0;
    Stack<int> stack = new Stack<int>();
    int result;
    for(int i = 0; i < a.Count; i++)
    {
        while(stack.Count > 0)
        {
            result = stack.Peek() ^ a[i];
            maxResult = Math.Max(maxResult, result);

            if(stack.Peek() > a[i])
            {
                stack.Pop();
            }
            else
            {
                break;
            }
        }
        stack.Push(a[i]);
    }

    return maxResult;
}

Console.WriteLine(andXorOr(new List<int>() { 9, 6, 3, 5, 2 }));
