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

Console.Write("Enter decimal number to convert: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[FindArrSize(num)];