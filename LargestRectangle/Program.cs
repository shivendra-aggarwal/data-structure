// See https://aka.ms/new-console-template for more information



//static long largestRectangle(List<int> h)
//{
//    int avg_height;
//    int sum_heights = 0;
//    int max_size = 0;
//    List<int> building_counts = new List<int>();
//    for (int i = 0; i < h.Count; i++)
//    {
//        sum_heights += h[i];
//    }
//    int building_counter = 0;
//    avg_height = sum_heights / h.Count;

//    for (int index = 0; index < h.Count; index++)
//    {
//        while (index < h.Count && h[index] >= avg_height)
//        {
//            building_counter++;
//            index++;
//        }

//        if (building_counter > 0)
//        {
//            building_counts.Add(building_counter);
//            building_counter = 0;
//        }
//    }

//    foreach (var count in building_counts)
//    {
//        if (max_size < count)
//        {
//            max_size = count;
//        }
//    }

//    return max_size * avg_height;

//}

//static long largestRectangle(List<int> h)
//{
//    long sum = 0;
//    long local_avg;
//    long local_size = 0;
//    int min = 0;
//    for (int i = 0; i < h.Count; i++)
//    {
//        sum += h[i];
//    }
//    local_avg = sum / h.Count;
//    List<int> buildings = new List<int>();

//    for (int i = 0; i < h.Count; i++)
//    {
//        while (i < h.Count && h[i] >= local_avg)
//        {
//            min = min == 0 ? h[i] : Math.Min(min, h[i]);
//            buildings.Add(h[i]);
//            i++;
//        }

//        if (buildings.Count > 0)
//        {
//            local_size = min * buildings.Count;
//            if (buildings.Count > 1 && h.Count != buildings.Count)
//            {
//                local_size = Math.Max(local_size, largestRectangle(buildings));
//                buildings.Clear();
//            }
//        }

//    }

//    return local_size;

//}

static long largestRectangle(List<int> h)
{
    int[] left = new int[h.Count];
    int[] right = new int[h.Count];
    Stack<int> stack = new Stack<int>();
    long temp, max_size = 0;
    for (int i = 0; i < h.Count; i++)
    {
        while (stack.Count > 0 && h[stack.Peek()] >= h[i])
        {
            stack.Pop();
        }
        left[i] = stack.Count == 0 ? 0 : stack.Peek() + 1;
        stack.Push(i);
    }
    stack.Clear();
    for (int i = h.Count - 1; i >= 0; i--)
    {
        while (stack.Count > 0 && h[stack.Peek()] >= h[i])
        {
            stack.Pop();
        }
        right[i] = stack.Count == 0 ? h.Count - 1 : stack.Peek() - 1;
        stack.Push(i);

        temp = (right[i] - left[i] + 1) * h[i];
        if (max_size < temp) max_size = temp;
    }

    return max_size;
}


//Console.WriteLine(largestRectangle(new List<int>() { 2, 1, 5, 6, 2, 3 }));
//Console.WriteLine(largestRectangle(new List<int>() { 1, 3, 5, 9, 11 }));
//Console.WriteLine(largestRectangle(new List<int>() { 3, 2, 3 }));
Console.WriteLine(largestRectangle(new List<int>() { 1, 2, 3, 4, 5 }));