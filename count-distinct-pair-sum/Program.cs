void Print(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

void Fill(int[] arr)
{
    int len = arr.Length;
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(0, 10);
    }
}

void FindUniqSums(int []arr)
{
    HashSet<int> s = new HashSet<int>();
    int len = arr.Length;
    for (int i = 0; i < len - 1; i++)
    {
        for (int j = i + 1; j < len; j++)
        {
            s.Add(arr[i] + arr[j]);
        }
    }
    Console.WriteLine(s.Count);
}

int[] array = new int[4];
Fill(array);
Console.Write("Original array: ");
Print(array);