
double FindMaxAverage(int[] nums, int k)
{
    double cur_sum = 0;
    double cur_avg = 0;
    double avg;
    for (int i = 0; i < k; i++)
    {
        cur_sum += nums[i];
    }

    cur_avg = cur_sum / k; 

    for (int i = k; i < nums.Length; i++)
    {

        cur_sum += nums[i];
        cur_sum -= nums[i - k];

        avg = cur_sum / k;

        cur_avg = Math.Max(avg, cur_avg);

    }

    return cur_avg;
}


Console.WriteLine(FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4));


Console.WriteLine(FindMaxAverage(new int[] { 5 }, 1));
