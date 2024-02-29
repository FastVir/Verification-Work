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

