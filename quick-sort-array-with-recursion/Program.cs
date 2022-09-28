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

void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}

int[] array = new int[10];
Fill(array);
Console.Write("Original array: ");
Print(array);