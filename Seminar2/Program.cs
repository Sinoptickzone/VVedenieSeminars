// Задача 1: Введите 3-значное число, выведите этоже число без 2 цифры.

// Console.Write("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine()!);

// int num = new Random().Next(100, 1000);

// int result = (num / 100) * 10 + num % 10;

// Console.WriteLine($"{num} {result}");


// Строковый метод

// Console.WriteLine("Введите трехзначное число: ");
// string number = Console.ReadLine()!;
// Console.WriteLine($"{number} -> {number[0]}{number[2]}");


// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int ran = new Random().Next(10, 100);

// if(ran/10 > ran%10)
// {
//     Console.WriteLine($"{ran} -> {ran/10}");
// }
// else
// {
//     Console.WriteLine($"{ran} -> {ran%10}");
// }


// 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите первое число: ");
// int b = int.Parse(Console.ReadLine()!);

// if (a % b > 0)
// {
//     Console.WriteLine($"не кратно, остаток {a % b}");
// }
// else
// {
//     Console.WriteLine("кратно");
// }


// 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// Console.Write("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);

// if (x % 7 == 0 && x % 23 == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }


// 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// Console.Write("Введите первое число: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите первое число: ");
// int N = int.Parse(Console.ReadLine()!);

// if (M * M == N || N * N == M)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }