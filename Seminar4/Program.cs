// // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Сумма чисел от 1 до {A} равна: {GetSum(A)}");

// int GetSum(int lim)
// {
//     int sum = 0;

//     for (int i = 1; i <= lim; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }


// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int B = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Количество цифр в числе {B} равно: {Count(B)}");

// int Count(int N)
// {
//     int kol = 0;

//     if (N != 0)
//     {
//     while (N > 0)
//     {
//         N = N/10;
//         kol++;
//     }
//     return kol;
//     }
//     else
//     {
//         return 1;
//     }
// }


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

// Console.Write("Введите число: ");
// int M = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Произведение чисел от 1 до {M} равно: {Product(M)}");

// int Product(int K)
// {
//    int Mul = 1;
//    if (K > 0)
//    {
//        for(int x = 2; x <= K; x++)
//        {
//            Mul = Mul * x;
//        }
//        return Mul;
//    }
//    else
//    {
//        return 0;
//    }
// }


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.Write("Введите размер массива: ");
// int L = int.Parse(Console.ReadLine()!);

// int[] array = FillArray(L);
// Console.WriteLine($"[{String.Join("; ", array)}]");

// int[] FillArray(int size)
// {
//     int[] Res = new int[size];
//     for (int k=0; k < size; k++)
//     {
//         Res[k] = new Random().Next(2);
//         k++;
//     }
//     return Res;
// }


// Определить, является ли заданное шестизначное число счастливым. (Счастливым называют такое шестизначное число, 
// что сумма его первых трех цифр равна сумме его последних трех цифр)

// Console.Write("Введите шестизначное число: ");
// string S = Console.ReadLine()!;

// if (Happy(S))
// {
//     Console.WriteLine("Число счастливое");
// }
// else
// {
//     Console.WriteLine("Не счастливое число");
// }

// bool Happy(string str)
// {
//     if (str.Length == 6)
//     {
//         if (str[0]+str[1]+str[2] == str[3]+str[4]+str[5])
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
//     else
//     {
//         return false;
//     }
// }
