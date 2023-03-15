// // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void CheckQuarter(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine("Точка находится в первой четверти");
//     }
//     else if (x < 0 && y > 0)
//     {
//         System.Console.WriteLine("Точка находится во второй четверти");
//     }
//     else if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine("Точка находится в третьей четверти");
//     }
//     else if (x > 0 && y < 0)
//     {
//         System.Console.WriteLine("Точка находится в четвертой четверти");
//     }
//     else if (x == 0 || y == 0)
//     {
//         System.Console.WriteLine("Точка находится на осях");
//     }
// }

// int[] coords = new int[2];
// coords[0] = ReadInt("Введите Х: ");
// coords[1] = ReadInt("Введите Y: ");
// CheckQuarter(coords[0], coords[1]);


// Задача: Напишите программу, которая принимает на вход номер четверти, а выдает возможные значения координаты точки (X и Y). 


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void CheckQuarter(int quarter)
// {

//     switch (quarter)
//     {
//         case 1: 
//             {
//                 System.Console.Write("x>0, y>0");
//                 break;
//             }
//         case 2:
//             {
//                 System.Console.Write("x<0, y<0");
//                 break;
//             }
//         case 3:
//             {
//                 System.Console.Write("x<0, y<0");
//                 break;
//             }
//         case 4:
//             {
//                 System.Console.Write("x>0, y<0");
//                 break;
//             }
//         default:
//             {
//                 System.Console.Write("Такой четверти не существует ");
//                 break;
//             }
//     }


//     // if (quarter == 1)
//     // {
//     //     System.Console.Write("x>0, y>0");
//     // }
//     // else if (quarter == 2)
//     // {
//     //     System.Console.Write("x<0, y>0");
//     // }
//     // else if (quarter == 3)
//     // {
//     //     System.Console.Write("x<0, y<0");
//     // }
//     // else if (quarter == 4)
//     // {
//     //     System.Console.Write("x>0, y<0");
//     // }
//     // else
//     // {
//     //     System.Console.Write("Такой четверти не существует ");
//     // }
// }

// int number = ReadInt("Введите номер четверти ");
// CheckQuarter(number);


// Задача: Вычислить расстояние между 2-мя точками на плоскости.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int[] a = new int[2];
// int[] b = new int[2];
// a[0] = ReadInt("Введите координату X точки A: ");
// a[1] = ReadInt("Введите координату Y точки A: ");
// b[0] = ReadInt("Введите координату X точки B: ");
// b[1] = ReadInt("Введите координату Y точки B: ");
// double res = Math.Round(Math.Sqrt(Math.Pow(a[0]-b[0], 2) + Math.Pow(a[1]-b[1], 2)), 3);
// System.Console.WriteLine("Расстояние между точками = " + res);


// Задача. Вывести квадраты всех чисел от 1 до N.

// int ReadInt(string text)
// {
//   System.Console.Write(text);
//   return Convert.ToInt32(Console.ReadLine());
// }

// void NumberPow(int number)
// {
//   for (int i = 1; i <= number; i++)
//   {
//     System.Console.Write(Math.Pow(i, 2) + " ");
//   }
// }

// int number = ReadInt("Введите число: ");
// NumberPow(number);