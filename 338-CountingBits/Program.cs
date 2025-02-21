int[] CountBits(int n)
{
    int[] result = new int[n + 1];
    int offset = 1;

    for (int i = 1; i < n + 1; i++)
    {
        if (offset * 2 == i)
            offset = i;
        result[i] = 1 + result[i - offset];
    }

    return result;
}

Console.WriteLine(string.Join(" ", CountBits(2)));


