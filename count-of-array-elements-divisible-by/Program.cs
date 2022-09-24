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

(int, string) FindValid(int[] arr)
{
    int len = arr.Length;
    string validElem = String.Empty;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        int p = arr[i];
        int sum = 0;
        int prod = 1;
        while (p > 0)
        {
            int r = p % 10;
            sum += r;
            prod *= r;
            p /= 10;
        }
        if ((sum > 0 && arr[i] % sum == 0) || (prod > 0 && arr[i] % prod == 0))
        {
            validElem += arr[i] + " ";
            count++;
        }
    }
    return (count, validElem);
}

void PrintValid(int[] arr)
{
    (int count, string validElem) = FindValid(arr);
    Console.WriteLine("Number of elements divisible by their product or sum of digits: " + count);
    Console.WriteLine("Elements divisible by their product or sum of digits: " + validElem);
}

int[] array = new int[10];
Fill(array);
Console.Write("Original array: ");
Print(array);
PrintValid(array);