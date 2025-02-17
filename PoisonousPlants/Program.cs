// Brute force approach, complexity n*n
//static int poisonousPlants(List<int> p)
//{
//    return poisonousPlantDays(p, 1);
//}

//static int poisonousPlantDays(List<int> p, int day)
//{
//    if (p.Count == 0)
//    {
//        return day - 1;
//    }
//    bool isPoisonousPlantFound = false;
//    int i = 1;
//    List<int> result = new List<int>();
//    result.Add(p[0]);
//    while (i < p.Count)
//    {
//        if (p[i - 1] < p[i])
//        {
//            isPoisonousPlantFound = true;
//        }
//        else
//        {
//            result.Add(p[i]);
//        }
//        i++;
//    }

//    if (!isPoisonousPlantFound)
//    {
//        return day - 1;
//    }
//    else
//    {
//        return poisonousPlantDays(result, ++day);
//    }
//}


//optimized approach, complexity n
static int poisonousPlants(List<int> p)
{
    Stack<Item> stack = new Stack<Item>();
    int day = 0, maxday = 0;

    foreach (int item in p)
    {
        day = 0;
        while (stack.Count > 0 && stack.Peek().plant >= item)
        {
            day = Math.Max(day, stack.Pop().day);
        }

        if(stack.Count > 0)
        {
            day++;
        }
        else
        {
            day = 0;
        }

        maxday = Math.Max(maxday, day);
        stack.Push(new Item() { plant = item, day = day });
    }

    return maxday;
}



//Console.WriteLine(poisonousPlants(new List<int>() { 3, 6, 2, 7, 5 }));
Console.WriteLine(poisonousPlants(new List<int>() { 6, 5, 8, 4, 7, 10, 9 }));

struct Item
{
    public int plant;
    public int day;
}
