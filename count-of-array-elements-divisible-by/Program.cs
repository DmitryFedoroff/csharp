﻿void Print(int[] arr)
{
    Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void Fill(int[] arr)
{
    int len = arr.Length;
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
}

int[] array = new int[10];
Fill(array);
Console.Write("Original array: ");
Print(array);