// See https://aka.ms/new-console-template for more information
static List<int> rotateLeft(int d, List<int> arr)
{
    int index = 0;
    int[] result = new int[arr.Count];

    for (int j = 0; j < arr.Count; j++)
    {
        index = j + (arr.Count - d);
        if (index >= arr.Count)
        {
            result[index - arr.Count] = arr[j];
        }
        else
        {
            result[index] = arr[j];
        }
    }


    return result.ToList();

}
List<int> ar = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine(string.Join(" ", rotateLeft(1, ar)));
