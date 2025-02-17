void MoveZeroes(int[] nums)
{
    int temp, l = 0;

    for(int r = 0; r < nums.Length; r++)
    {
        if (nums[r] != 0)
        {
            temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
            l++;
        }
    }
}

int[] input = new int[] { 0, 1, 0, 3, 12 };

MoveZeroes(input);

Console.Write(string.Join(" ", input));

int[] input1 = new int[] { 1, 0, 0, 3, 12 };

MoveZeroes(input1);

Console.Write(string.Join(" ", input1));