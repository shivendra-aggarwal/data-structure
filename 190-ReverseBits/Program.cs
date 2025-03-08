uint reverseBits(uint n)
{
    uint res = 0;
    uint bit = 0;
    for(int i = 0; i <= 32; i++)
    {
        Console.WriteLine(n >> i);
        //bit = (n >> i) & 1;
        //res = res | (bit << (31 - i));

    }

    return res;
}

Console.WriteLine(reverseBits(43261596));