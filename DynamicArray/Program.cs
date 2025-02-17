// See https://aka.ms/new-console-template for more information
static List<int> dynamicArray(int n, List<List<int>> queries)
{
    List<int> result = new List<int>();
    List<List<int>> arr = new List<List<int>>();

    for (int j = 0; j < n; j++)
    {
        arr.Add(new List<int>());
    }

    int idx = 0, type = 0, x = 0, y = 0, lastAnswer = 0;

    for (int i = 0; i < queries.Count; i++)
    {
        type = queries[i][0];
        x = queries[i][1];
        y = queries[i][2];
        idx = (x ^ lastAnswer) % n;
        if (type == 1)
        {
            arr[idx].Add(y);
        }
        else
        {
            lastAnswer = arr[idx][y % arr[idx].Count];
            result.Add(lastAnswer);
        }
    }

    return result;
}


Console.WriteLine(string.Join(",", dynamicArray(2, new List<List<int>>()
{
    new List<int> { 1, 0, 5 },
    new List<int> { 1, 1, 7 },
    new List<int> { 1, 0, 3 },
    new List<int> { 2, 1, 0 },
    new List<int> { 2, 1, 1 }
})));
