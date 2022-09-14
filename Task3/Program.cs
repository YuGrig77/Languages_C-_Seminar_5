// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Write($"{(position == 0 ? coll[position] : "," + coll[position])}"); - метод вывода одной строкой

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int count = 0;
Console.WriteLine("Введите число для проверки на наличие в массиве: ");
int n = int.Parse(Console.ReadLine());

int[] array = GetArray(5, 1, 10);
Console.Write("массив [");
for (int i = 0; i < array.Length; i++)
{
    if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}"); // \r\n
    if (array[i] == n)
    {
        count++;
    }
}
Console.Write("] ");
Console.Write((count == 0 ? $"-> нет " : $"-> да, {count} раз(а)"));
//Console.Write(((count==2 || count==3 || count==4) ? "раза" : "раз"));


// ++OR++

// Console.Clear();
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     Console.Write("[");
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");
//     }
//     Console.Write("]");
//     return res;
// }

// int[] array = GetArray(12, -9, 9);
// Console.WriteLine();
// //запрос числа для поиска
// Console.WriteLine("Введите число для поиска в массиве: ");
// int number = int.Parse(Console.ReadLine());

// // булева переменная - присутствие / отсутствие в массиве
// bool boolResult = ArraySearch(array, number); 

// //вывод результатов в консоль
// Console.WriteLine($"Входит ли число {number} в массив? -> {BoolToString(boolResult)}"); 

// //метод поиска заданного числа в массиве
// bool ArraySearch(int[] arrayToSearch, int numberToSearch)
// {
//     foreach(int arrayelement in arrayToSearch)
//     {
//         if (arrayelement == numberToSearch)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// //метод - вывод "да" при ист

// ++OR++

// Console.Clear();

// Console.WriteLine("Вы участвуете в лотереи, введите число от 1 до 10, и попытайте удачу ");
// int number = int.Parse(Console.ReadLine());

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");
//     }
//     Console.WriteLine(" ");
//     return res;
// }

// int[] array = GetArray(7, 1, 10);


// int res = 0;
// foreach (int el in array)
// {
//     if (number == el)
//         res = 1;
// }
// if (res == 1)
// {
//     Console.WriteLine("YOU ARE WINNER");
// }
// else
// {
//     Console.WriteLine("Попытайте удачу еще раз, YOU ARE LOSSER");
// }

