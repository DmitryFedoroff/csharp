void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
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
                minElemRow = i;
                minElemCol = j;
            }        
        }   
    }
    return (minElem, minElemRow, minElemCol);
}

void PrintMinVal(int[,] arr)
{
    char[] splitChars = { ' ', ',', '(', ')' };
    string[] val = (FindMinVal(arr).ToString()).Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine("First smallest element = {0}; Row index = {1}; Column index = {2}.", val[0], val[1], val[2]);
    Console.WriteLine();
}

int[,] CreateNewArr(int[,] arr)
{
    int[,] arrNew = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    (int min, int iMin, int jMin) = FindMinVal(arr);
    for (int i = 0; i < arrNew.GetLength(0); i++)
    {
        for (int j = 0; j < arrNew.GetLength(1); j++)
        {
            if (i < iMin && j < jMin)
            {
                arrNew[i, j] = arr[i, j]; 
            }
            else if (i >= iMin && j < jMin)
            {
                arrNew[i, j] = arr[i + 1, j];
            }
            else if (i < iMin && j >= jMin)
            {
                arrNew[i, j] = arr[i, j + 1];
            }
            else
            {
                arrNew[i, j] = arr[i + 1, j + 1];
            }        
        }
    }
    return arrNew;    
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
Print(CreateNewArr(array));