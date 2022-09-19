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

Console.Write("Enter position of rotation: ");
int k = int.Parse(Console.ReadLine());
int[] array = GetData("input-data.txt");