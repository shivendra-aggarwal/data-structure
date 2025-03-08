
int MaxNumberOfBalloons(string text)
{
    Dictionary<string, int> ballonCounter = GetCharCounter("balloon");
    Dictionary<string, int> charCounter = GetCharCounter(text);

    int min = int.MaxValue;

    foreach (var item in ballonCounter)
    {
        if (charCounter.ContainsKey(item.Key))
        {
            min = Math.Min(min, charCounter[item.Key] / item.Value);
        }
        else
        {
            return 0;
        }
    }

    return min;
}

Dictionary<string, int> GetCharCounter(string text)
{
    Dictionary<string, int> charCounter = new Dictionary<string, int>();

    foreach (char c in text)
    {
        if (charCounter.ContainsKey(c.ToString()))
        {
            charCounter[c.ToString()]++;
        }
        else
        {
            charCounter.Add(c.ToString(), 1);
        }
    }

    return charCounter;
}


Console.WriteLine(MaxNumberOfBalloons("nlaebolko")); // 1

Console.WriteLine(MaxNumberOfBalloons("loonbalxballpoon")); // 2