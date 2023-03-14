string[] StringArray(int n)
{
    string[] inarray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку: ");
        string input = Console.ReadLine()!;
        inarray[i] = input;
    }
    return inarray;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < 1; i++)
    {
        Console.Write("[");
        Console.Write(String.Join(" ", array));
        Console.Write("] ");
    }
}
string[] ChangeArray(string[] inarray)
{
    string[] array = new string[inarray.Length];
    for (int i = 0; i < inarray.Length; i++)
    {
        string input = inarray[i];
        if (input.Length <= 3)
        {
            array[i] = input;
        }
    }
    return array;
}

Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = StringArray(n);
PrintArray(array);
string[] newarray = ChangeArray(array);
PrintArray(newarray);