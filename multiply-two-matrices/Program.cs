void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Fill(int[,] matrx)
{
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            matrx[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.Write("Enter number of matrix rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter number of matrix columns: ");
int m = int.Parse(Console.ReadLine());
int[,] matrixA = new int[n, m];
int[,] matrixB = new int[m, n];
Console.WriteLine();
Fill(matrixA);
Fill(matrixB);