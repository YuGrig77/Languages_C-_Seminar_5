// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] tripple = new int[length];
    for (int i = 0; i < length; i++)
    {
        tripple[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{tripple[i]} ");
    }
    return tripple;
}
int[] array = GetArray(5, 100, 1000);

int Compare(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
            count = count + 1;
        else
            count = count;
    }
    return count;
}
Console.Write($"=> {Compare(array)}");
