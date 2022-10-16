
string[] FillArray(string[] arrayint)
{
    for (int i = 0; i < arrayint.Length; i++)
    {
        Console.Write($"Введите элемент (текст или число) массива № {i + 1} : ");
        arrayint[i] = Convert.ToString(Console.ReadLine());
    }
    return arrayint;
}

void SearchArrayLength(string[] array1, string[] array2)
{
    int count = default;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]} ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
string[] arrayint = new string[arrLength];
string[] newarr = FillArray(arrayint);
string[] arrayresult = new string[newarr.Length];
Console.WriteLine("------------------------");
Console.Write("Получен массив: ");
Console.WriteLine();
PrintArray(newarr);
Console.WriteLine();
Console.WriteLine("------------------------");
Console.WriteLine("Массив с элементами меньше или равно 3: ");
SearchArrayLength(newarr, arrayresult);
PrintArray(arrayresult);
Console.WriteLine();