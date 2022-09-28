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

int[] QuickSort(int[] inputArray, int minIdx, int maxIdx)
{
    if (minIdx >= maxIdx) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIdx, maxIdx);
    QuickSort(inputArray, minIdx, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIdx);
    return inputArray;
}

int GetPivotIndex(int[] inputArray, int minIdx, int maxIdx)
{
    int pivotIdx = minIdx - 1;
    for (int i = minIdx; i < maxIdx; i++)
    {
        if (inputArray[i] < inputArray[maxIdx])
        {
            pivotIdx++;
            Swap(inputArray, i, pivotIdx);
        }
    }
    pivotIdx++;
    Swap(inputArray, pivotIdx, maxIdx);
    return pivotIdx;
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
Console.Write("Sorted array with quick sort using recursion: ");
Print(QuickSort(array, 0, array.Length - 1));