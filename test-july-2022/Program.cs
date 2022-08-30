void Print(string[] array)
{
    foreach (string element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)" };