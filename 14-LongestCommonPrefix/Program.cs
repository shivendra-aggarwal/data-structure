string LongestCommonPrefix(string[] strs)
{
    Array.Sort(strs);

    string smallest = strs[0];
    string largest = strs[strs.Length - 1];
    List<char> result = new();

    for(int i = 0; i <smallest.Length; i++)
    {
        if(smallest[i] != largest[i])
        {
            return new string(result.ToArray());
        }

        result.Add(smallest[i]);
    }

    return new string(result.ToArray());
}

Console.WriteLine(
    $"Longest Common Prefix " +
    $"{LongestCommonPrefix(new string[] { "flower", "flow", "flight", "flasdflkasjdflkajdsl" })}");

Console.WriteLine(
    $"Longest Common Prefix " +
    $"{LongestCommonPrefix(new string[] { "dog", "racecar", "car" })}");

Console.WriteLine(
    $"Longest Common Prefix " +
    $"{LongestCommonPrefix(new string[] { "dog" })}");

Console.WriteLine(
    $"Longest Common Prefix " +
    $"{LongestCommonPrefix(new string[] { "reflower", "flow", "flight" })}");