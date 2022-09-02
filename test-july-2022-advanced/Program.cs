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

string[] array = ReadInputStream("Введите элементы массива: ");
int charLim = 3;