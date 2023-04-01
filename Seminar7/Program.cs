// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows,columns, 0, 10);
// PrintArray(array);


// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = i+j. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArrayIndex(rows,columns, 0, 10);

// int[,] GetArrayIndex(int m, int n, int minValue, int maxValue)
// {
//     int[,] res = new int[m,n];

//     for (int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++){
//             res[i, j] = i + j;
//         }
//     }
//     return res;
// }

// PrintArray(array);


// **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 **49** 2
// 5 9 2 3
// **64** 4 **4** 4

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);

// int[,] newArray = GetArrayPow(array);

// int[,] GetArrayPow(int[,] arr)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
//         }
//     }
//     return arr;
// }

// Console.WriteLine();
// PrintArray(newArray);


// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows,columns, 0, 10);
// PrintArray(array);

// int GetDiagonalSum(int[,] arr)
// {
//     int sum = 0;

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (i == j) 
//             {
//                 sum += (arr[i,j]);
//             }
//         }
//     }
//     return sum;
// }

// Console.WriteLine(GetDiagonalSum(array));

// ----------------Общие методы---------------

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] res = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             res[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return res;
// }

// void PrintArray(int[,] array)
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