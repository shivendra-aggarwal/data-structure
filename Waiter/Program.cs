static List<int> waiter(List<int> number, int q)
{
    var primes = getPrimeNumberList(q);
    List<int> result = new List<int>();
    Stack<int>[] stackA = new Stack<int>[q + 1];
    Stack<int>[] stackB = new Stack<int>[q + 1];
    stackA[0] = new Stack<int>();
    stackB[0] = new Stack<int>();

    number.ForEach(a =>
    {
        stackA[0].Push(a);
    });

    try
    {
        for (int i = 0; i < q; i++)
        {
            stackA[i + 1] = new Stack<int>();
            stackB[i + 1] = new Stack<int>();
            while (stackA[i].Count > 0)
            {
                var plate = stackA[i].Pop();
                if (plate % primes[i] == 0)
                {
                    stackB[i + 1].Push(plate);
                }
                else
                {
                    stackA[i + 1].Push(plate);
                }
            }
        }

        for (int i = 0; i < q + 1; i++)
        {
            while (stackB[i].Count > 0)
            {
                result.Add(stackB[i].Pop());
            }
        }

        for (int i = 0; i < q + 1; i++)
        {
            while (stackA[i].Count > 0)
            {
                result.Add(stackA[i].Pop());
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    return result.ToList();
}

static List<int> getPrimeNumberList(int q)
{
    List<int> primes = new List<int>();
    primes.Add(2);
    primes.Add(3);

    for (int i = 1; primes.Max() < 37 && primes.Count < q; i++)
    {
        primes.Add((6 * i) - 1);
        primes.Add((6 * i) + 1);
    }

    if (primes.Count < q)
    {
        for (int i = 0; primes.Count < q; i++)
        {
            primes.Add((i * i) + i + 41);
        }
    }

    return primes;
}


//Console.WriteLine(string.Join(" ", waiter(new List<int>() { 2, 3, 4, 5, 6, 7 }, 3)));
//Console.WriteLine(string.Join(" ", waiter(new List<int>() { 3, 4, 7, 6, 5 }, 1)));
//Console.WriteLine(string.Join(" ", waiter(new List<int>() { 3, 3, 4, 4, 9 }, 2)));

string[] lines = File.ReadAllLines("./TestCases/TestCase1/input.txt");
string[] output = File.ReadAllLines("./TestCases/TestCase1/output.txt");
List<int> testOutput = new List<int>();
foreach (string line in output)
{
    testOutput.Add(int.Parse(line));
}
int q = int.Parse(lines[0].Split(" ")[1]);
List<int> numbers = lines[1].Split(" ").Select(a => int.Parse(a)).ToList();
List<int> result = waiter(numbers, q);
for (int i = 0; i < result.Count; i++)
{
    if (result[i] != testOutput[i])
    {
        Console.WriteLine($"found different element {result[i]} at index {i}");
    }
}

Console.ReadLine();