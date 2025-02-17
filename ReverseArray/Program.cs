using System.Linq;
// See https://aka.ms/new-console-template for more information
static List<int> reverseArray(List<int> a)
{
    int temp;
    for (int i = 0, j = a.Count - 1; i <= j; i++, j--)
    {
        temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }

    return a;
}

List<int> ar = new List<int> {  };
Console.WriteLine(string.Join("\n", reverseArray(ar)));