void Print(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
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

void Swap(int[] arr, int a, int b)
{
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}

int[] SortWave(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i+= 2)
    {
        if (i > 0 && arr[i - 1] > arr[i])
        {
            Swap(arr, i - 1, i);
        }
        if (i < len - 1 && arr[i] < arr[i + 1])
        {
            Swap(arr, i, i + 1);
        }
    }
    return arr;
}

int[] array = new int[10];
Fill(array);
Console.Write("Unsorted array: ");
Print(array);