﻿void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
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

int[,] ReplaceElem(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i, j] = (int)Math.Pow(arr[i, j], 2);
            }
            else
            {
                arr[i, j] = (int)Math.Pow(arr[i, j], 3);
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
Console.WriteLine("Original array: ");
Print(array);
Console.WriteLine("Updated array: ");
Print(ReplaceElem(array));