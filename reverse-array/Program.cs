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

int[] ReverseArray(int[] arr)
{
    int temp;
    int len = arr.Length;
    for (int i = 0; i < len / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[len - 1 - i];
        arr[len - 1 - i] = temp;
    }
    return arr;
}

int[] array = new int[10];
Fill(array);
Console.Write("Original array: ");
Print(array);
Console.Write("Reversed array: ");
Print(ReverseArray(array));