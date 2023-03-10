// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);

// int max = a;

// if (b > max) max = b;

// Console.WriteLine($"max = {max}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int y = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int z = int.Parse(Console.ReadLine()!);

// int maximum = x;

// if (y > maximum) maximum = y;
// if (z > maximum) maximum = z;

// Console.WriteLine(maximum);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// if (number%2 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);

// int A = 2;

// while (A <= N)
// {
//     if (A % 2 == 0)
//     {
//         Console.Write($"{A}");
//         if (A + 1 < N) Console.Write(", ");
//     }
//     A++;
// }