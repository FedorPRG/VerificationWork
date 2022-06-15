string PrintarrayString(string[] mass)
{
    string res = string.Empty;
    res = "[";
    for (int i = 0; i < mass.Length - 1; i++)
    {
        res += $"{mass[i]}, ";
    }
    res += $"{mass[mass.Length - 1]}]";
    return res;
}
string[] Solve(string[] array)
{
    string[] finishArray = new string[1];
    int k = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref finishArray, k = k + 1);
            finishArray[j] = array[i];
            j++;
        }
    }
    return finishArray;
}
Console.Write("Введите строки массива, разделенные между собой запятой, точкой или пробелом: ");
string a = Console.ReadLine()!;
char[] separators = new char[] { ' ', '.', ',' };
string[] startArray = a.Split(separators, StringSplitOptions.RemoveEmptyEntries);
Console.Write(PrintarrayString(startArray) + "->" + PrintarrayString(Solve(startArray)));