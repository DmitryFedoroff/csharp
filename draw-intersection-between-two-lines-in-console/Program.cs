void CheckParallel(int k1, int k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("The lines are parallel. There is no point\u001B[32m ⦿ \u001b[0m of intersection."); // ANSI .NET color green \u001B[32m       
    }
    Console.WriteLine();
}

Console.WriteLine("Enter data to find intersection point of two lines.");
Console.WriteLine("For example, b1 = 2, k1 = 5, b2 = 4, k2 = 9");
Console.Write("Enter b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Enter k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Enter b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Enter k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine();
CheckParallel(k1, k2);