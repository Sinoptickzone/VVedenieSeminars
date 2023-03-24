// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int size = ReadVariable("Введите размер массива: ");

// int[] array = GetRandomArray(size, 100, 999);
// Console.WriteLine($"[{String.Join(",", array)}]");

// Console.WriteLine($"Количество четных елементов: {CountEven(array)}");

// int CountEven(int[] arr)
// {
//     int kol = 0;

//     foreach (int el in arr)
//     {
//         if (el % 2 == 0) kol++;
//     }
//     return kol;
// }


// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int size = ReadVariable("Введите размер массива: ");
// int min = ReadVariable("Введите минимальное значение элемента: ");
// int max = ReadVariable("Введите максимальное значение элемента: ");

// int[] array = GetRandomArray(size, min, max);
// Console.WriteLine($"[{String.Join(",", array)}]");

// Console.WriteLine($"Сумма елементов с нечетными индексами: {SumNotEvenElements(array)}");

// int SumNotEvenElements(int[] arr)
// {
//     int sum = 0;
//     int i = 1;

//     while (i < size)
//     {
//         sum = sum + arr[i];
//         i = i + 2;
//     }

//     return sum;
// }


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)
// [3, 7.4, 22.3, 2, 78] -> 76

int size = ReadVariable("Введите размер массива: ");
int min = ReadVariable("Введите минимальное значение элемента: ");
int max = ReadVariable("Введите максимальное значение элемента: ");

int[] array = GetRandomArray(size, min, max - 1);

double[] NewArray = new double[size];
double maximum = min;
double minimum = max;

for (int k = 0; k < size; k++)
{
    Random d = new Random();
    NewArray[k] = array[k] + Math.Round(d.NextDouble(), 1);
    if (NewArray[k] > maximum) maximum = NewArray[k];
    if (NewArray[k] < minimum) minimum = NewArray[k];
}

Console.WriteLine($"[{String.Join(" ", NewArray)}]");
Console.WriteLine($"Разница между максимальным {maximum} и минимальным {minimum} элементами равна: {Math.Round(maximum - minimum,1)}");


// -------------------------------Общие методы-------------------------------------------

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int ReadVariable(string message)
{
    Console.Write(message);
    int var = int.Parse(Console.ReadLine()!);
    return var;
}