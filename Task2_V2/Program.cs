// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();
//метод - генерация нового массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.Write("]");
    return res;
}

//создание и заплнение нового массива через метод
int[] array = GetArray(12, -9, 9);

Console.WriteLine();

//вызов метода замены элементов массива
ArrayReplace(array);

void ArrayReplace(int[] Array1)
{
    int length = Array1.Length;
    for (int k = 0; k < length; k++)
    {
        Array1[k] = -Array1[k];
    }
}
//вывод массива после замены элементов
PrintArray(array);

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    foreach (int arrayelem in arrayToPrint)
    {
        Console.Write($"{arrayelem} ");
    }
    Console.Write("]");
}

