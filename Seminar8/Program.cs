// **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows,columns, 0, 9);
// PrintArray(array);

// int[,] RearrangeFirstLastString (int[,] arr)
// {
//     int temp = 0;
//     for (int j=0; j < columns; j++)
//     {
//         temp = arr[0,j];
//         arr[0,j] = arr[rows-1,j];
//         arr[rows-1,j] = temp;
//     }
//     return arr;
// }

// Console.WriteLine();
// PrintArray(RearrangeFirstLastString(array));


// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows,columns, 0, 9);
// PrintArray(array);

// int[,] RearrangeStringsRows (int[,] arr)
// {
//     int[,] newArr = new int[rows,columns];

//     for (int i=0; i < columns; i++)
//     {
//         for (int j=0; j < columns; j++)
//         {
//             newArr[j,i] = arr[i,j];
//         }
//     }
//     return newArr;
// }

// Console.WriteLine();
// if (rows==columns) PrintArray(RearrangeStringsRows(array));
// else Console.WriteLine("Количество строк не равно столбцам!");


// **Задача 56:** Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);

// int GetMinString(int[,] arr)
// {
//     int minSum = 0;
//     int minRow = 0;

//     for (int k = 0; k < columns; k++)
//     {
//         minSum += arr[0, k];
//     }

//     for (int i = 0; i < rows; i++)
//     {
//         int sum = 0;

//         for (int j = 0; j < columns; j++)
//         {
//             sum += arr[i, j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             minRow = i;
//         }
//     }
//     return minRow;
// }

// Console.WriteLine($"Наименьшая сумма элементов в {GetMinString(array) + 1} строке");


// **Задача 59**: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);

// int[] GetMinElement(int[,] arr)
// {
//     int minElement = arr[0, 0];
//     int[] minCoords = new int[] { 0, 0 };

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             if (arr[i, j] < minElement)
//             {
//                 minElement = arr[i, j];
//                 minCoords[0] = i;
//                 minCoords[1] = j;
//             }
//         }
//     }
//     return minCoords;
// }

// int[,] ChangeArray(int[,] arr, int[] coords)
// {
//     int[,] newArr = new int[rows - 1, columns - 1];
//     int m = 0;
//     int n = 0;

//     for (int i = 0; i < rows; i++)
//     {
//         if (i == coords[0]) continue;
//         for (int j = 0; j < columns; j++)
//         {
//             if (j == coords[1]) continue;
//             newArr[m, n] = arr[i, j];
//             n++;
//         }
//         n = 0;
//         m++;
//     }
//     return newArr;
// }

// Console.WriteLine($"Удалили строку и столбец с индексами минимального элемента: [{String.Join(",", GetMinElement(array))}]");

// PrintArray(ChangeArray(array, GetMinElement(array)));

// ------------------------------Общие методы------------------------------

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
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