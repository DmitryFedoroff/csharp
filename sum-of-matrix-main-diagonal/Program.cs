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

Console.Write("Enter number of matrix rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter number of matrix columns: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[n, m];
Fill(matrix);
Print(matrix);