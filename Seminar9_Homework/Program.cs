// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Вредите натуральное число: ");
// int N = int.Parse(Console.ReadLine()!);

// if (N >= 1) Console.WriteLine(PrintNumbers(N, 1));

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start - 1, end));
// }


// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Вредите первое число: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Вредите второе число: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(SumNumbers(M, N));

// int SumNumbers(int start, int end)
// {
//     if (start == end) return start;
//     return (start + SumNumbers(start + (start < end ? 1 : -1), end));
// }


// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Вредите первое число: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Вредите второе число: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(Ackermann(M, N));

// int Ackermann(int X, int Y)
// {
//     if (X == 0) return Y + 1;
//     if (X > 0 && Y == 0) return Ackermann(X - 1, 1);
//     if (X > 0 && Y > 0) return Ackermann(X - 1, Ackermann(X, Y - 1));
//     else return 0;
// }
