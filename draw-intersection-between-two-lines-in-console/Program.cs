void CheckParallel(int k1, int k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("The lines are parallel. There is no point\u001B[32m ⦿ \u001b[0m of intersection."); // ANSI .NET color green \u001B[32m       
    }
    Console.WriteLine();
}

void PrintTable(int[,] coordTable, int k, int b)
{
    int xi = -2; int xj = -2; // initial x value in the first row of the table
    for (int i = 0; i < coordTable.GetLength(0); i++)
    {
        for (int j = 0; j < coordTable.GetLength(1); j++)
        {
            if (i == 1 && j > 2 && j % 2 != 0)
            {
                coordTable[i, j] = xi++;
                if (coordTable[i, j] >= 0 && coordTable[i, j] < 10)
                {
                    Console.Write(" " + coordTable[i, j] + " ");
                }
                else if (coordTable[i, j] < 0 && coordTable[i, j] > -10)
                {
                    Console.Write(coordTable[i, j] + " ");
                }
                else if (coordTable[i, j] >= 10 && coordTable[i, j] < 100)
                {
                    Console.Write(" " + coordTable[i, j]);
                }
                else
                {
                    Console.Write(coordTable[i, j]);
                }
            }
            else if (i == 3 && j > 2 && j % 2 != 0)
            {
                coordTable[i, j] = k * xj++ + b; // y values in the second row of the table
                if (coordTable[i, j] >= 0 && coordTable[i, j] < 10)
                {
                    Console.Write(" " + coordTable[i, j] + " ");
                }
                else if (coordTable[i, j] < 0 && coordTable[i, j] > -10)
                {
                    Console.Write(coordTable[i, j] + " ");
                }
                else if (coordTable[i, j] >= 10 && coordTable[i, j] < 100)
                {
                    Console.Write(" " + coordTable[i, j]);
                }
                else
                {
                    Console.Write(coordTable[i, j]);
                }
            }
            // frame of a coordinate table based on a two-dimensional array
            else if (i == 1 && j == 1) Console.Write(" X ");
            else if (i == 3 && j == 1) Console.Write(" Y ");
            else if (i == 0 && j == 0) Console.Write("┌");
            else if (i == 4 && j == 0) Console.Write("└");
            else if (i == 0 && j == coordTable.GetLength(1) - 1) Console.Write("┐");
            else if (i == 4 && j == coordTable.GetLength(1) - 1) Console.Write("┘");
            else if (i == 2 && j != 0 && j % 2 == 0 && j < coordTable.GetLength(1) - 1) Console.Write("┼");
            else if (i == 2 && j == 0) Console.Write("├");
            else if (i == 2 && j == coordTable.GetLength(1) - 1) Console.Write("┤");
            else if (i == 0 && j != 0 && j % 2 == 0 && j < coordTable.GetLength(1) - 1) Console.Write("┬");
            else if (i == 4 && j != 0 && j % 2 == 0 && j < coordTable.GetLength(1) - 1) Console.Write("┴");
            else if (i % 2 != 0 && j % 2 == 0) Console.Write("│");
            else Console.Write("───");
        }
        Console.WriteLine();
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