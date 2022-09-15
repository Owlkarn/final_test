Console.WriteLine("Ddtlb");
string rty = Console.ReadLine();
string[] qwe = new string[0];
int count = 0;

while (rty != "ex")
{
    if (rty != "")
    {
        count++;
        string[]ewq = new string[count];
        for (int i = 0; i < count-1; i++)
        ewq[i] = qwe[i];
        ewq[count-1] = rty;
        qwe = ewq;        
    }
    Console.WriteLine("effggf");
    rty = Console.ReadLine(); 
}
void PrintArray(string[] array)
{
    Console.Write("Текущий массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
PrintArray(qwe);

Console.WriteLine("max length");
int size = Convert.ToInt32(Console.ReadLine()); 
count = 0;
string[] qwe2 = new string[0];
for (int i = 0; i < qwe.Length; i++)
{
    if (qwe[i].Length <= size)
    {
        count++;
        string[]ewq = new string[count];
        for (int j = 0; j < count-1; j++)
        ewq[j] = qwe2[j];
        ewq[count-1] = qwe[i];
        qwe2 = ewq;
    }
}
PrintArray(qwe2);