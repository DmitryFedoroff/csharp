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

string[] array = { "hello", "2", "world", ":-)" };
Console.WriteLine("Первоначальный массив строк: ");
Print(array);
Console.WriteLine();