// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] arrayR = new int[length];
    for (int i = 0; i < length; i++)
    {
        arrayR[i] = new Random().Next(minValue, maxValue);
        //Console.Write($"{arrayR[i]}");
    }
    return arrayR;
}

int FindMaxNumber(int[] resFMN)
{
    int maxNumber = resFMN[0];
    for (int i = 1; i < resFMN.Length; i++)
    {
        if (resFMN[i] > maxNumber)
            maxNumber = resFMN[i];
    }
    return maxNumber;
}

int FindMinNumber(int[] resFMN)
{
    int minNumber = resFMN[0];
    for (int i = 1; i < resFMN.Length; i++)
    {
        if (resFMN[i] < minNumber)
            minNumber = resFMN[i];
    }
    return minNumber;
}

void PrintArray(int[] resPA)
{
    Console.Write("[ ");
    for (int i = 0; i < resPA.Length; i++)
    {
        Console.Write((i == resPA.Length - 1 ? $"{resPA[i]} ] " : $"{resPA[i]}, "));
    }
}

int[] array = GetArray(4, 0, 100);
PrintArray(array);
//Console.Write($" => maxNumber {FindMaxNumber(array)}");
//Console.Write($" => minNumber {FindMinNumber(array)}");
Console.Write($" => {FindMaxNumber(array) - FindMinNumber(array)}");

