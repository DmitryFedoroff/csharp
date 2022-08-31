void Print(string[] array)
{
    foreach (string element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

int CountElem(string[] inputArray)
{
    int i = 0;
    int count = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i].Length <= 3)
        {
            count++; 
        }
        i++;    
    }
    return count;
}

string[] CreateArr(string[] inputArray)
{
    string[] outputArray = new string [CountElem(inputArray)];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
    }
    return outputArray;
}

string[] array = { "hello", "2", "world", ":-)" };
Console.WriteLine("Первоначальный массив строк: ");
Print(array);
Console.WriteLine();