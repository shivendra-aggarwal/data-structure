IList<int> GetRow(int rowIndex)
{
    IList<int> row = new List<int>();
    row.Add(1);
    if (rowIndex == 0) return row;
    long prev = 1;
    long nextValue = 0;

    for (int i = 1; i <= rowIndex; i++)
    {
        nextValue = prev * (rowIndex - i + 1) / i;
        row.Add((int)nextValue);
        prev = nextValue;

    }
    return row;
}

var row = GetRow(0);

Console.WriteLine(string.Join(" ", row));
