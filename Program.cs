string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] newArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return newArray;
}


