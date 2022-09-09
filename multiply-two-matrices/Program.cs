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

int [,] Multiply(int[,] matrixA, int[,] matrixB)
{
    int rowA = matrixA.GetLength(0);
    int columnA = matrixA.GetLength(1);
    int rowB = matrixB.GetLength(0);
    int columnB = matrixB.GetLength(1);
    int temp = 0;
    int[,] matrixC = new int[rowA, columnB];
    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < columnB; j++)
        {
            temp = 0;
            for (int k = 0; k < columnA; k++)
            {
                temp += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = temp;
        }
    }
    return matrixC;
}

Console.Write("Enter number of matrix rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter number of matrix columns: ");
int m = int.Parse(Console.ReadLine());
int[,] matrixA = new int[n, m];
int[,] matrixB = new int[m, n];
Console.WriteLine();
Fill(matrixA);
Console.WriteLine("Matrix A:");
Print(matrixA);
Fill(matrixB);
Console.WriteLine("Matrix B:");
Print(matrixB);