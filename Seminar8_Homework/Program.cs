// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int rows = ReadVariable("Введите количество строк массива: ");
// int columns = ReadVariable("Введите количество столбцов массива: ");

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);

// int[,] SortRowsDescending(int[,] arr)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns - 1; j++)
//         {
//             int maxPosition = j;

//             for (int k = j + 1; k < columns; k++)
//             {
//                 if (arr[i, k] > arr[i, maxPosition])
//                 {
//                     maxPosition = k;
//                 }
//             }
//             int temp = arr[i, j];
//             arr[i, j] = arr[i, maxPosition];
//             arr[i, maxPosition] = temp;
//         }
//     }
//     return arr;
// }

// Console.WriteLine();
// PrintArray(SortRowsDescending(array));


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// int rows = ReadVariable("Введите количество строк массива: ");
// int columns = ReadVariable("Введите количество столбцов массива: ");

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);

// int[] ToOneDimensionalArray(int[,] arr)
// {
//     int[] newArr = new int[rows * columns];
//     int k = 0;

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArr[k] = arr[i, j];
//             k++;
//         }
//     }
//     return newArr;
// }

// void CountSameElements(int[] arr)
// {
//     for (int m = 0; m < arr.Length; m++)
//     {
//         int temp = 0;
//         int count = 0;

//         if (arr[m] >= 0)
//         {
//             temp = arr[m];

//             for (int n = 0; n < arr.Length; n++)
//             {
//                 if (arr[n] == temp)
//                 {
//                     arr[n] = -1;
//                     count++;
//                 }
//             }
//             Console.WriteLine($"{temp} встречается {count} раз(а)");
//         }
//     }
// }

// Console.WriteLine();
// CountSameElements(ToOneDimensionalArray(array));


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int rowsA = ReadVariable("Введите количество строк 1 матрицы: ");
// int columnsA = ReadVariable("Введите количество столбцов 1 матрицы: ");

// int rowsB = columnsA;
// int columnsB = ReadVariable("Введите количество столбцов 2 матрицы: ");

// int[,] arrayA = GetArray(rowsA, columnsA, 0, 9);
// PrintArray(arrayA);

// Console.WriteLine();

// int[,] arrayB = GetArray(rowsB, columnsB, 0, 9);
// PrintArray(arrayB);

// int[,] MatrixProduct(int[,] arrA, int[,] arrB)
// {
//     int[,] arrC = new int[rowsA, columnsB];

//     for (int i = 0; i < rowsA; i++)
//     {
//         for (int j = 0; j < columnsB; j++)
//         {
//             for (int k = 0; k < rowsB; k++)
//             {
//                 arrC[i, j] += arrA[i, k] * arrB[k, j];
//             }
//         }
//     }
//     return arrC;
// }

// Console.WriteLine();
// PrintArray(MatrixProduct(arrayA, arrayB));


// -------------------Задачи повышенной сложности---------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int x = ReadVariable("Введите размер матрицы по горизонтали: ");
// int y = ReadVariable("Введите размер матрицы по вертикали: ");
// int z = ReadVariable("Введите глубину матрицы: ");

// PrintArrayWithIndexes(GetThreeDimensionArray(x, y, z, 10, 99));

// int[,,] GetThreeDimensionArray(int rows, int columns, int depth, int minValue, int maxValue)
// {
//     int[,,] res = new int[rows, columns, depth];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             for (int k = 0; k < depth; k++)
//                 res[i, j, k] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return res;
// }

// void PrintArrayWithIndexes(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04          00 01 02 03  4-3-3-2-2-1-1
// 12 13 14 05          10 11 12 13
// 11 16 15 06          20 21 22 23
// 10 09 08 07          30 31 32 33

// int[,] array = new int[4, 4];
// int count = 1;

// for (int j = 0; j < 4; j++)
// {
//     array[0, j] = count;
//     count++;
// }
// for (int i = 1; i < 4; i++)
// {
//     array[i, 3] = count;
//     count++;
// }
// for (int j = 2; j >= 0; j--)
// {
//     array[3, j] = count;
//     count++;
// }
// for (int i = 2; i > 0; i--)
// {
//     array[i, 0] = count;
//     count++;
// }
// for (int j = 1; j < 3; j++)
// {
//     array[1, j] = count;
//     count++;
// }
// for (int i = 2; i < 3; i++)
// {
//     array[i, 2] = count;
//     count++;
// }
// for (int j = 1; j < 2; j++)
// {
//     array[2, j] = count;
//     count++;
// }
// for (int i = 1; i < 0; i--)
// {
//     array[i, 1] = count;
//     count++;
// }
// PrintArray(array);

// -------------------------------Общие методы-------------------------------------------

int ReadVariable(string message)
{
    Console.Write(message);
    int v = int.Parse(Console.ReadLine()!);
    return v;
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