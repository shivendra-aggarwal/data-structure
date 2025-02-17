int MaxProfit(int[] prices)
{
    int maxProfit = 0;
    int minPrice = int.MaxValue;
    

    foreach(int currentPrice in prices)
    {
        minPrice = Math.Min(currentPrice, minPrice);
        maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
    }

    return maxProfit;
}

Console.WriteLine($"Max profit is: {MaxProfit(new int[] { 7, 1, 5, 3, 6, 4, 8 })}");