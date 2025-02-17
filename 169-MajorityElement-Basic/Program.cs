
int MajorityElement(int[] nums)
{
    Dictionary<int, int> count = new Dictionary<int, int>();
    int res = 0, maxCount = 0;

    for(int i = 0; i < nums.Length; i++)
    {
        if (count.ContainsKey(nums[i]))
            count[nums[i]]++;
        else
            count.Add(nums[i], 1);
        res = count[nums[i]] > maxCount ? nums[i] : res;
        maxCount = Math.Max(count[nums[i]], maxCount);
    }
    return res;
}

Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));

Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));