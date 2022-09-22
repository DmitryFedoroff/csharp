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

// another frame of a coordinate table based on a two-dimensional array
double[,] cross = new double[,]
{
    { 3, 0, 10,  0,  0,  5 },
    {12, 1, 12, -1, 13, 12 },
    { 8, 0,  7,  0,  0,  9 },
    {12, 2, 12, -2, 13, 12 },
    { 4, 0, 11,  0,  0,  6 },
};

void PrintCrossTable(double[,] CrossTable, int k1, int b1, int k2, int b2)
{
    for (int i = 0; i < CrossTable.GetLength(0); i++)
    {
        for (int j = 0; j < CrossTable.GetLength(1); j++)
        {
            if (CrossTable[i, j] == -1)
            {
                CrossTable[i, j] = Math.Round((double)(b2 - b1) / (k1 - k2), 1);
                if (CrossTable[i, j] >= 0 && CrossTable[i, j] < 10)
                {
                    Console.Write("  " + CrossTable[i, j] + " ");
                }
                else if (CrossTable[i, j] < 0 || CrossTable[i, j] >= 10 
                    && CrossTable[i, j] < 100)
                {
                    Console.Write(" " + CrossTable[i, j] + " ");
                }
                else
                {
                    Console.Write(CrossTable[i, j]);
                }
            }
            else if (CrossTable[i, j] == -2)
            {
                CrossTable[i, j] = Math.Round((double)(k1 * b2 - k2 * b1) / (k1 - k2), 1);
                if (CrossTable[i, j] >= 0 && CrossTable[i, j] < 10)
                {
                    Console.Write("  " + CrossTable[i, j] + " ");
                }
                else if (CrossTable[i, j] < 0 && CrossTable[i, j] > -10
                    || CrossTable[i, j] >= 10 && CrossTable[i, j] < 100)
                {
                    Console.Write(" " + CrossTable[i, j] + " ");
                }
                else
                {
                    Console.Write(CrossTable[i, j]);
                }
            }
            else if (CrossTable[i,j] == 0) Console.Write("───");
            else if (CrossTable[i,j] == 1) Console.Write(" X ");
            else if (CrossTable[i,j] == 2) Console.Write(" Y ");
            else if (CrossTable[i,j] == 3) Console.Write("┌");
            else if (CrossTable[i,j] == 4) Console.Write("└");
            else if (CrossTable[i,j] == 5) Console.Write("┐");
            else if (CrossTable[i,j] == 6) Console.Write("┘");
            else if (CrossTable[i,j] == 7) Console.Write("┼");
            else if (CrossTable[i,j] == 8) Console.Write("├");
            else if (CrossTable[i,j] == 9) Console.Write("┤");
            else if (CrossTable[i,j] == 10) Console.Write("┬");
            else if (CrossTable[i,j] == 11) Console.Write("┴");
            else if (CrossTable[i,j] == 12) Console.Write("│");
            else Console.Write("");
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
int[,] arr = new int[5, 13]; // template of a two-dimensional array for a table of x and y coordinates of 5 points
Console.WriteLine("\u001B[34mTable of values for 1st line: \u001b[0m"); // ANSI .NET color blue \u001B[34m
PrintTable(arr, k1, b1);
Console.WriteLine("\u001B[31mTable of values for 2nd line: \u001b[0m"); // ANSI .NET color red \u001B[31m
PrintTable(arr, k2, b2);
Console.WriteLine("\u001B[32mCoordinates of intersection point: \u001b[0m"); // ANSI .NET color green \u001B[32m
PrintCrossTable(cross, k1, b1, k2, b2);