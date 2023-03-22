// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Expo(int A, int B)
// {
//     int res = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         res = res * A;
//     }
//     return res;
// }

// Console.Write("Введите основание степени: ");
// int X = int.Parse(Console.ReadLine()!);
// Console.Write("Введите показатель степени: ");
// int Y = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{X} в степени {Y} равно {Expo(X, Y)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Count(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }

// Console.Write("Введите число: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр числа {M}: {Count(M)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// int[] array = new int[8];

// void FillArray(int[] arr)
// {
//     int lenght = arr.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         arr[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
//     //Console.WriteLine($"[{String.Join(",", arr)}]");  //Вывод элементов массива в квадратных скобках
// }

// FillArray(array);
// PrintArray(array);