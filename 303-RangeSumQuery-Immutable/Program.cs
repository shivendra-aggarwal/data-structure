

NumArray obj = new(new int[] { -2, 0, 3, -5, 2, -1 });
Console.WriteLine(obj.SumRange(0, 2));
Console.WriteLine(obj.SumRange(2, 5));
Console.WriteLine(obj.SumRange(0, 5));


public class NumArray
{
    private int[] prefixSum;
    public NumArray(int[] nums)
    {
        prefixSum = new int[nums.Length];
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
            prefixSum[i] = sum;
        }

    }

    public int SumRange(int left, int right)
    {
        int rightSum = prefixSum[right];
        int leftSum = left > 0 ? prefixSum[left - 1] : 0;
        return rightSum - leftSum;
    }
}

