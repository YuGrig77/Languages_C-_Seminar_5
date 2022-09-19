// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

Console.WriteLine("Вы участвуете в лотереи, введите число от 1 до 10, и попытайте удачу ");
int number = int.Parse(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine(" ");
    return res;
}

int[] array = GetArray(7, 1, 10);


int res = 0;
foreach (int el in array)
{
    if (number == el)
        res = 1;
}
if (res == 1)
{
    Console.WriteLine("YOU ARE WINNER");
}
else
{
    Console.WriteLine("Попытайте удачу еще раз, YOU ARE LOSSER");
}


