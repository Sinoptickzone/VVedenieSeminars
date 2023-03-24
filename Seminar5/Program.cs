// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// int[] array = GetRandomArray(12, -9, 9);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int positiveSum = 0;
// int negativeSum = 0;

// foreach (int el in array)
// {
//     positiveSum += el > 0 ? el : 0;  // тернарный оператор
//     negativeSum += el < 0 ? el : 0;
// }

// Console.WriteLine($"Positive sum = {positiveSum}, Negative sum = {negativeSum}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = GetRandomArray(5, -9, 9);
// Console.WriteLine($"[{String.Join(",", array)}]");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i]*(-1);
//     //array[i] *=-1
// }

// Console.WriteLine($"[{String.Join(",", array)}]");


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] array = GetRandomArray(6, 1, 7);

// Console.Write("Введите искомое число: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"[{String.Join(",", array)}]");

// if (Check(array, M))
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// bool Check(int[] arr, int num)
// {
//     foreach (int el in arr)
//     {
//         if (el == num) return true;
//     }
//     return false;
// }


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = GetRandomArray(123, 0, 1000);
// Console.WriteLine($"[{String.Join(",", array)}]");

// Console.WriteLine(Count(array));

// int Count(int[] array)
// {
//     int sum = 0;

//     // for (int j = 0; j < array.Length; j++)
//     // {
//     //     if (9 < array[j] && array[j] < 100)
//     //     {
//     //         sum++;
//     //     }
//     // }
//     // return sum;

//     foreach (int el in array)
//     {
//         if (9 < el && el < 100) sum++;
//     }
//     return sum;
// }


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array = GetRandomArray(9, 0, 10);
// Console.WriteLine($"[{String.Join(",", array)}]");
// int B = 0;

// if (array.Length % 2 > 0)
// {
//     B = array.Length / 2 + 1;
// }
// else
// {
//     B = array.Length / 2;
// }

// Console.WriteLine($"[{String.Join(",", Count(array))}]");

// int[] Count(int[] arr)
// {
//     int[] newarr = new int[B];

//     for (int x = 0; x < B; x++)
//     {
//         if (x != arr.Length - 1 - x)
//         {
//             newarr[x] = arr[x] * arr[arr.Length - 1 - x];
//         }
//         else
//         {
//             newarr[x] = arr[x];
//         }
//     }
//     return newarr;
// }

// -------------------------------Общий метод-------------------------------------------

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return result;
// }