int RemoveDuplicates(int[] nums)
{
    int k = 1;
    int p1 = 0, p2 = 0;
    
    while (p2 < nums.Length)
    {
        if(nums[p2] != nums[p1])
        {
            nums[p1 + 1] = nums[p2];
            p1++;
            k++;
        }
        p2++;
    }

    Console.WriteLine(String.Join(" ", nums));

    return k;
}

Console.WriteLine(RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));

Console.WriteLine(RemoveDuplicates(new int[] { 1, 1, 2 }));