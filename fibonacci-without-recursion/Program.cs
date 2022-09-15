﻿void Print(int[] fiboNums)
{
    foreach (int number in fiboNums)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

Console.Write("Enter length of Fibonacci series: ");
int numsLimit = int.Parse(Console.ReadLine());
int[] array = new int[numsLimit];