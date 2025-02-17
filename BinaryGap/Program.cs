static int getBinaryGap(int value)
{
    string binary = Convert.ToString(value, 2);
    int maxGap = 0;
    int binaryGapCounter = 0;
    int gapCounter = 0;
    for (int i = 0; i < binary.Length; i++)
    {
        if (binary[i] == '1' && binaryGapCounter < 2)
        {
            binaryGapCounter++;
        }

        if (binaryGapCounter == 2)
        {
            binaryGapCounter--;
            maxGap = Math.Max(maxGap, gapCounter);
            gapCounter = 0;
        }

        if (binary[i] == '0')
        {
            gapCounter++;
        }
    }
    return maxGap;
}

Console.WriteLine(String.Format("Max gap = {0}", getBinaryGap(1041)));