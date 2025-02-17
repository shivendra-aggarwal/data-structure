int SingleNumber(int[] nums)
{
    // Not valid for negative values scenario

    //int max = 0;
    //int singleNumber = 0;
    //for (int i = 0; i < nums.Length; i++)
    //{
    //    max = Math.Max(max, nums[i]);
    //}

    //int[] temp = new int[max + 1];

    //for (int i = 0; i < nums.Length; i++)
    //{
    //    temp[nums[i]]++;
    //}

    //for (int i = 0; i < temp.Length; i++)
    //{
    //    if (temp[i] == 1)
    //    {
    //        singleNumber = i;
    //    }
    //}

    //return singleNumber;


    int result = nums[0];

    if (nums.Length == 1) return result;

    for (int i = 1; i < nums.Length; i++)
    {
        result = result ^ nums[i];
    }

    return result;
}

Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
Console.WriteLine(SingleNumber(new int[] { 1 }));