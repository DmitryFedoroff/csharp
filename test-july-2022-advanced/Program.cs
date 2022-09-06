string[] ReadInputStream(string msg)
{
ReInput:
    Console.Write(msg);
    string? str = Console.ReadLine();
    if (str != String.Empty && str != " ")
    {
        char[] splitChars = { ' ', ',' };
        string[] inputArray = str.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
        return inputArray;
    }
    else
    {
        Console.WriteLine("Вы ничего не ввели!");
        Console.WriteLine();
        goto ReInput;
    }
}

string Print(string[] arr)
{
    string output = String.Empty;
    foreach (string element in arr)
    {
        output += (element + " ");
    }
    return output;
}

void PrintConsole(string[] arr, int charLim)
{
    if (arr.Length != 0 && arr.Length != CountElem(arr, charLim))
    {
        string inputCons = Print(arr);
        Console.WriteLine("Исходный массив строк: " + inputCons);
        Console.WriteLine();
    }
    else if (arr.Length != 0 && arr.Length == CountElem(arr, charLim))
    {
        string outputCons = Print(arr);
        Console.WriteLine("Массив строк длиной меньше либо равной 3 символа: " + outputCons);
        Console.WriteLine();
    }
    else if (arr.Length == 0)
    {
        Console.WriteLine("В исходном массиве нет строк длиной меньше либо равной 3 символа.");
    }
}

int CountElem(string[] inputArray, int charLim)
{
    int i = 0;
    int count = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i].Length <= charLim)
        {
            count++;
        }
        i++;
    }
    return count;
}

string[] CreateArr(string[] inputArray, int charLim)
{
    string[] outputArray = new string [CountElem(inputArray, charLim)];
    int index = CountElem(inputArray, charLim);
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= charLim)
        {
            outputArray[outputArray.Length - index] = inputArray[i];
            index--;
        }
    }
    return outputArray;
}

void WriteToFile(string[] arr, int charLim)
{
    if (arr.Length != 0 && arr.Length != CountElem(arr, charLim))
    {
        string inputFile = Print(arr);
        File.WriteAllText("input.txt", inputFile);
        Console.WriteLine("Исходный массив строк сохранен в файл input.txt");
        Console.WriteLine();
    }
    else if (arr.Length != 0 && arr.Length == CountElem(arr, charLim))
    {
        string outputFile = Print(arr);
        File.WriteAllText("output.txt", outputFile);
        Console.WriteLine("Массив строк длиной меньше либо равной 3 символа сохранен в файл output.txt");
        Console.WriteLine();
    }
}

string[] array = ReadInputStream("Введите элементы массива: ");
int charLim = 3;
Console.WriteLine();
PrintConsole(array, charLim);
WriteToFile(array, charLim);
PrintConsole(CreateArr(array, charLim), charLim);
WriteToFile(CreateArr(array, charLim), charLim);