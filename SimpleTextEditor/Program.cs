using System.Text;

static void Main(String[] args)
{
    //int length = int.Parse(Console.ReadLine());
    int length = int.Parse(args[0]);
    string[] new_line;
    Stack<StringBuilder> stack = new Stack<StringBuilder>();
    StringBuilder S = new StringBuilder();
    for (int i = 1; i < length; i++)
    {
        new_line = args[i].Split(" ");
        //string[] new_line = Console.ReadLine().Split(" ");
        
        switch (new_line[0])
        {
            case "1":
                stack.Push(new StringBuilder(S.ToString()));
                S.Append(new_line[1]);
                break;
            case "2":
                stack.Push(new StringBuilder(S.ToString()));
                S = S.Remove(S.Length - int.Parse(new_line[1]), int.Parse(new_line[1]));
                break;
            case "3":
                Console.WriteLine(S[int.Parse(new_line[1]) - 1]);
                break;
            case "4":
                S = stack.Pop();
                break;
        }

    }
}


Main(new string[]
{
    "8",
    "1 abc",
    "3 3",
    "2 3",
    "1 xy",
    "3 2",
    "4",
    "4",
    "3 1"
});