string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] newArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return newArray;
}

string PrintArray(string[] newArray)
{
    string stringArray = "[";
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == newArray.Length - 1)
        {
            stringArray += $"\"{newArray[i]}\"";
            break;
        }
        stringArray += ($"\"{newArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] newArray)
{
    int counter = 0;
    foreach (string item in newArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] CreateNewArray(string[] newArray)
{
    int resultArrayLength = CountStringSymbols(newArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in newArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}


string[] newArray = FillArray();
string[] resultArray = CreateNewArray(newArray);
string firstArray = PrintArray(newArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);