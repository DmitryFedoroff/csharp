int FindArrSize(int num)
{
    int temp = num;
    int count = 0;
    while (temp != 0)
    {
        temp = temp / 2;
        count++;
    }
    return count;
}

int[] ConvertToBinary(int[] arr, int num)
{
    int i = 0;
    while (num != 0)
    {
        arr[i] = num % 2;
        num = num / 2;
        i++;
    }
    return arr;
}

void PrintBinaryNum(int[] arr, int num)
{
    arr = ConvertToBinary(arr, num);
    for (int j = arr.Length - 1; j >= 0; j--)
    {
        Console.Write(arr[j]);
    }
    Console.WriteLine();
}

Console.Write("Enter decimal number to convert: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[FindArrSize(num)];
PrintBinaryNum(array, num);