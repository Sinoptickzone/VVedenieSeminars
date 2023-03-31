// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = ReadVariable("Введите количество строк массива: ");
// int n = ReadVariable("Введите количество столбцов массива: ");

// int[,] array = GetArray(m, n, 10, 99);

// double[,] GetDoubleArray(int[,] arr)
// {
//     double[,] newArr = new double[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArr[i, j] = Math.Round(arr[i, j] + (new Random().NextDouble()), 1);
//         }
//     }
//     return newArr;
// }

// void PrintDoubleArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] doubleArr = GetDoubleArray(array);
// PrintDoubleArray(doubleArr);


// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет

// int m = ReadVariable("Введите количество строк массива: ");
// int n = ReadVariable("Введите количество столбцов массива: ");
// int x = ReadVariable("Введите номер строки элемента: ");
// int y = ReadVariable("Введите номер столбца элемента: ");

// int[,] array = GetArray(m, n, 10, 99);

// bool Validate(int str, int col, int[,] arr)
// {
//     return (str <= arr.GetLength(0) && col <= arr.GetLength(1) && str > 0 && col > 0);
// }

// PrintArray(array);

// if (Validate(x,y,array)) Console.WriteLine($"Элемент найден: {array[x-1,y-1]}");
// else Console.WriteLine("Элемент не существует!");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int m = ReadVariable("Введите количество строк массива: ");
// int n = ReadVariable("Введите количество столбцов массива: ");

// int[,] array = GetArray(m, n, 1, 9);

// PrintArray(array);

// double[] ColumnAverage(int[,] arr)
// {
//     double[] newArr = new double[n];

//     for (int j = 0; j < n; j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < m; i++)
//         {
//             sum += arr[i, j];
//         }
//         newArr[j] = Math.Round(sum / m, 2);
//     }
//     return newArr;
// }

// Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join(" ", ColumnAverage(array))}");

// -------------------------------Общие методы-------------------------------------------

int ReadVariable(string message)
{
    Console.Write(message);
    int var = int.Parse(Console.ReadLine()!);
    return var;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] res = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}