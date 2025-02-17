// See https://aka.ms/new-console-template for more information


static string isBalanced(string s)
{
    const string YES = "YES", NO = "NO";
    if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
    {
        return NO;
    }
    Stack<char> stack = new Stack<char>();
    Dictionary<int, int> keyValue = new Dictionary<int, int>()
    {
        { 40, 41 },
        { 91, 93 },
        { 123, 125 }
    };
    foreach (char c in s.Trim())
    {
        if (c == '{' || c == '(' || c == '[')
        {
            stack.Push(c);
        }
        else
        {
            if (stack.Count > 0)
            {
                char r = stack.Pop();

                if ((char)keyValue[(int)r] != c)
                {
                    return NO;
                }
            }
            else
            {
                return NO;
            }
        }
    }

    return stack.Count == 0 ? YES : NO;
}

Console.WriteLine(isBalanced("{[()]}"));
//Console.WriteLine(isBalanced("{[(])}"));
