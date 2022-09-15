void Print(int[] fiboNums)
{
    foreach (int number in fiboNums)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

int[] FillFiboNums(int[] fiboNums, int numsLimit)
{
    if (numsLimit > 2)
    {
        fiboNums[0] = 0;
        fiboNums[1] = 1;
        for (int i = 2; i < fiboNums.Length; i++)
        {
            fiboNums[i] = fiboNums[i - 2] + fiboNums[i - 1];
        }
    }
    else if (numsLimit == 2)
    {
        fiboNums[0] = 0;
        fiboNums[1] = 1;
    }
    return fiboNums;
}

Console.Write("Enter length of Fibonacci series: ");
int numsLimit = int.Parse(Console.ReadLine());
int[] array = new int[numsLimit];
Print(FillFiboNums(array, numsLimit));