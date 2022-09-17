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
    int rowLen = arr.GetLength(0);
    int colLen = arr.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < rowLen; i++)
    {
        for (int j = 0; j < colLen; j++)
        {
           arr[i, j] = rand.Next(0, 10);
        }
    }
}

(int, int, int) FindMinVal(int[,] arr)
{
    int minElemRow = 0;
    int minElemCol = 0;
    int minElem = arr[minElemRow, minElemCol];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minElem)
            {
                minElem = arr[i, j];
                (minElemRow, minElemCol) = (i, j);
            }
        }
    }
    return (minElem, minElemRow, minElemCol);
}

void PrintMinVal(int[,] arr)
{
    (int min, int iMin, int jMin) = FindMinVal(arr);
    Console.WriteLine("First smallest element = " + min + "; " + "Row index = " + iMin + "; " + "Column index = " + jMin + ".");
    Console.WriteLine();
}

void PrintNewArr(int[,] arr)
{
    (int min, int iMin, int jMin) = FindMinVal(arr);
    int rowLen = arr.GetLength(0);
    int colLen = arr.GetLength(1);
    for (int i = 0; i < rowLen; i++)
    {   
        for (int j = 0; j < colLen; j++)
        {
            if (i != iMin && j != jMin)
            {
               Console.Write(arr[i, j] + " ");
            }
        }
        if (i != iMin)
        {
            Console.WriteLine();
        }
    }
}

Console.Write("Enter number of array rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter number of array columns: ");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
Console.WriteLine();
Fill(array);
Print(array);
PrintMinVal(array);