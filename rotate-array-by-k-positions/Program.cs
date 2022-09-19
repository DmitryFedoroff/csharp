int[] GetData(string path)
{
    char[] splitChars = { ' ', ',', ':', ';', '.', '-', '"', '(', ')', '[', ']', '{', '}' };
    string[] res = File.ReadAllText(path).Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
    int[] numsInt = new int[res.Count()];
    for (int i = 0; i < numsInt.Length; i++)
    {
        numsInt[i] = int.Parse(res[i]);
    }
    return numsInt;
}

int[] RotateArr(int[] inputArr, int k)
{
    int len = inputArr.Length;
    if (k > len)
    {
        k = k % len;
    }    
    int[] result = new int[len];
    for (int i = 0; i < k; i++)
    {
        result[i] = inputArr[len - k + i];
    }
    int index = 0;
    for (int i = k; i < len; i++)
    {
        result[i] = inputArr[index++];
    }
    return result;
}

Console.Write("Enter position of rotation: ");
int k = int.Parse(Console.ReadLine());
int[] array = GetData("input-data.txt");