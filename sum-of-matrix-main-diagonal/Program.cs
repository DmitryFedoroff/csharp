﻿void Print(int[,] matr)
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

void Fill(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
}

int CalcDiagSum(int[,] matr)
{
    int diagSum = 0;
    int minLength = Math.Min(matr.GetLength(0), matr.GetLength(1));
    for (int i = 0; i < minLength; i++)
    {
        diagSum += matr[i, i];
    }
    return diagSum;
}

void PrintDiagSum(int[,] matr)
{
    Console.WriteLine("Sum of diagonal elements of matrix: " + CalcDiagSum(matr));
}

Console.Write("Enter number of matrix rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter number of matrix columns: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[n, m];
Fill(matrix);
Print(matrix);