// See https://aka.ms/new-console-template for more information

static List<int> matchingStrings(List<string> strings, List<string> queries)
{
    int[] result = new int[queries.Count];
    int counter = 0;
    foreach (var query in queries)
    {
        foreach (var str in strings)
        {
            if (query.Equals(str, StringComparison.OrdinalIgnoreCase))
            {
                result[counter]++;
            }
        }
        counter++;
    }
    return result.ToList();
}

Console.WriteLine(string.Join(",", matchingStrings(new List<string>() { "aba", "baba", "aba", "xzxb" }, new List<string>() { "aba", "xzxb", "ab" })));