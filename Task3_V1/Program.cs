// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

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

int[] array = GetArray(12, -9, 9);
Console.WriteLine();
//запрос числа для поиска
Console.WriteLine("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine());

// булева переменная - присутствие / отсутствие в массиве
bool boolResult = ArraySearch(array, number);

//вывод результатов в консоль
Console.WriteLine($"Входит ли число {number} в массив? -> {BoolToString(boolResult)}");

//метод поиска заданного числа в массиве
bool ArraySearch(int[] arrayToSearch, int numberToSearch)
{
    foreach (int arrayelement in arrayToSearch)
    {
        if (arrayelement == numberToSearch)
        {
            return true;
        }
    }
    return false;
}
//метод - вывод "да" при истинном и "нет" при фальшивом

string BoolToString(bool arg)
{
    if (boolResult == true) return "Да";
    else return "Нет";
}