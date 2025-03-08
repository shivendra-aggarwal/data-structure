
int NumIdenticalPairs(int[] nums)
{
    Dictionary<int, int> counter = GetHashMap(nums);
    int result = 0;

    foreach (var item in counter)
    {
        if (item.Value > 1)
        {
            result += item.Value * (item.Value - 1) / 2;
        }
    }
    return result;
}

Dictionary<int, int> GetHashMap(int[] nums)
{
    Dictionary<int, int> counter = new Dictionary<int, int>();

    foreach (int num in nums)
    {
        if (counter.ContainsKey(num))
        {
            counter[num]++;
        }
        else
        {
            counter.Add(num, 1);
        }
    }
    return counter;
}

Console.WriteLine(NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 })); // 4

Console.WriteLine(NumIdenticalPairs(new int[] { 1, 1, 1, 1 })); // 6