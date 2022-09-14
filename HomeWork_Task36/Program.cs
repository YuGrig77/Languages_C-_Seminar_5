// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] present = new int [size];
    for (int i = 0; i < size; i++)
    {
        present[i] = new Random().Next(minValue, maxValue);
    }
    return present;
}

int GetEllOnOddPos(int[] resGEOP)
{
    int length = resGEOP.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        sum += resGEOP[i];
        else
        sum = sum;
    }
    return sum;
}

void PrintArray(int[] resPA)
{
    Console.Write("[ ");
    for (int i = 0; i < resPA.Length; i++)
    {
        Console.Write((i == resPA.Length - 1 ? $"{resPA[i]} ] " : $"{resPA[i]}, "));
    }
}

int[] array = GetArray(6, -100, 100);
PrintArray(array);
Console.Write($"-> {GetEllOnOddPos(array)}");

