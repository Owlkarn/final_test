void PrintArray(string[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] AddStringToArray(string[] array)
{
    Console.Write("Введите элемент массива (чтобы закончить ввод элементов введите exit): ");
    string str = Console.ReadLine();
    int count = 0;

    while (str.ToLower() != "exit")
    {
        if (str != String.Empty)
        {
            count++;
            string[] tempArray = new string[count];
            for (int i = 0; i < count - 1; i++)
                tempArray[i] = array[i];
            tempArray[count - 1] = str;
            array = tempArray;
        }
        Console.Write("Введите элемент массива (чтобы закончить ввод элементов введите exit): ");
        str = Console.ReadLine();
    }
    Console.WriteLine();
    return array;
}
string[] lines = new string[0];
lines = AddStringToArray(lines);
PrintArray(lines);

Console.Write("Введите длинну элемента массива, равной или меньше которой будет производиться поиск: ");
int lgth = Convert.ToInt32(Console.ReadLine());
int count = 0;
string[] filterLines = new string[0];
for (int i = 0; i < lines.Length; i++)
{
    if (lines[i].Length <= lgth)
    {
        count++;
        string[] tempFilterLines = new string[count];
        for (int j = 0; j < count - 1; j++)
            tempFilterLines[j] = filterLines[j];
        tempFilterLines[count - 1] = lines[i];
        filterLines = tempFilterLines;
    }
}
PrintArray(filterLines);