Console.WriteLine("Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");

Console.WriteLine();
Console.Write("Введите количество элементов исходного массива: ");
int size = int.Parse(Console.ReadLine()!);


string?[] array = GetArray(size);
Console.WriteLine();
Console.Write("Полученный массив: ");
PrintArray(array);


string?[] GetArray(int size)
{
    Console.WriteLine("Введите элементы массива:");
    string?[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string?[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.Write("]");
}

