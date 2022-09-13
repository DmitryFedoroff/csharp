void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Fill(int[,] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(0, 10);
        }
    }
}

int[,] BubbleSortRow(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

int[,] BubbleSortCol(int[,] arr)
{
    int temp = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int k = i + 1; k < arr.GetLength(0); k++)
            {
                if (arr[i, j] > arr[k, j])
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[k, j];
                    arr[k, j] = temp;
                }
            }
        }
    }
    return arr;
}

Console.Write("Enter number of array rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter number of array columns: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[n, m];
Fill(array);
Console.WriteLine("Unsorted array: ");
Print(array);
Console.WriteLine("Array rows sorted in descending order: ");
Print(BubbleSortRow(array));
Console.WriteLine("Array columns sorted in ascending order: ");
Print(BubbleSortCol(array));