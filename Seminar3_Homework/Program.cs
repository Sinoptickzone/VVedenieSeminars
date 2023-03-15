// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.Write("Введите пятизначное число: ");
// string str = System.Console.ReadLine()!;

// if (str.Length == 5)
// {
//     if (str[0] == str[4] && str[1] == str[3])
//     {
//         System.Console.WriteLine("Палиндром");
//     }
//     else
//     {
//         System.Console.WriteLine("Не палиндром");
//     }
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не пятизначное число!");
// }


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] A = new int[3];
// int[] B = new int[3];

// A[0] = ReadInt("Введите координату X точки A: ");
// A[1] = ReadInt("Введите координату Y точки A: ");
// A[2] = ReadInt("Введите координату Z точки A: ");
// B[0] = ReadInt("Введите координату X точки B: ");
// B[1] = ReadInt("Введите координату Y точки B: ");
// B[2] = ReadInt("Введите координату Z точки B: ");

// double dst = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2));

// System.Console.WriteLine($"Расстояние между точками = {Math.Round(dst, 2)}");


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void NumberPow(int number)
{
  for (int i = 1; i <= number; i++)
  {
    System.Console.Write(Math.Pow(i, 3) + " ");
  }
}

int N = ReadInt("Введите число: ");
NumberPow(N);