string ReadString(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine();
    while (result == String.Empty)
    {
        Console.WriteLine("Строка пустая! Попробуйте ещё раз:");
        result = Console.ReadLine();
    }
    return result;
}

string RemoveExcessSplittersAndSpaces(string input, char splitter)
{
    input = input.Trim(' ');
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ' ' && input[i + 1] == ' ')
        {
            input = input.Remove(i, 1);
            i--;
        }
    input = input.Trim(splitter);
    for (int i = 0; i < input.Length; i++)
        if (input[i] == splitter && input[i + 1] == splitter)
        {
            input = input.Remove(i, 1);
            i--;
        }
    input = input.Trim(' ');
    return input;
}

int CountSplitters(string splitable, char splitter)
{
    int counter = 0;
    for (int i = 0; i < splitable.Length; i++)
    {
        if (splitable[i] == splitter)
            counter++;
    }
    return counter + 1;
}

void TrimElements(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i].Trim(' ');
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"|{array[i]}| ");
    Console.WriteLine();
}

string[] GetArray (string input)
{
    input = RemoveExcessSplittersAndSpaces(input, ',');
    int size = CountSplitters(input, ',');
    string[] result = input.Split(',', size);
    TrimElements(result);
    return result;
}



/*------------------MAIN-----------------------------*/
Console.Clear();


string a = ReadString("A!");
string[] aArray = GetArray(a);
PrintArray(aArray);