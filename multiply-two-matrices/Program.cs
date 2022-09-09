Console.Write("Enter number of matrix rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter number of matrix columns: ");
int m = int.Parse(Console.ReadLine());
int[,] matrixA = new int[n, m];
int[,] matrixB = new int[m, n];