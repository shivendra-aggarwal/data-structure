IList<IList<int>> Generate(int numRows)
{
    IList<IList<int>> triangle = new List<IList<int>>();

    if (numRows == 0) return triangle;

    triangle.Add(new List<int>() { 1 });

    if (numRows == 1) return triangle;

    for (int i = 1; i < numRows; i++)
    {
        var prevRow = triangle[i - 1];
        List<int> newRow = new List<int>();
        newRow.Add(1);
        for (int j = 1; j < i; j++)
        {
            newRow.Add(prevRow[j] + prevRow[j - 1]);
        }
        newRow.Add(1);
        triangle.Add(newRow);
    }

    return triangle;
}

var triangle = Generate(33);
foreach (var i in triangle)
{
    Console.WriteLine(string.Join(" ", i.ToArray()));
}