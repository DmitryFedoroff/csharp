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

int[] array = new int[4];
Fill(array);