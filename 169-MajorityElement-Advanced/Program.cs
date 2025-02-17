int MajorityElement(int[] nums) {
    int count = 0;
    int res =0;

    for (int i = 0; i < nums.Length; i++)
    {
        if(count == 0)
        {
            res = nums[i];
        }

        if(nums[i] == res)
        {
            count++;
        }
        else
        {
            count--;

        }
    }

    return res;

}

Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));

Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));