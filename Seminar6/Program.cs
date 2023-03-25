// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.Write("Введите стороны треугольника через пробел: ");
// string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

// if (IsTriangle(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2])))
// {
//     Console.WriteLine("ДА");
// }
// else
// {
//     Console.WriteLine("НЕТ");
// }
// // ----------Метод---------------
// bool IsTriangle(int a, int b, int c)
// {
//     return (((a + b) > c) && ((b + c) > a) && ((a + c) > b));
// }


// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101
// // 3 -> 11
// // 2 -> 10

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// string str1 = Convert.ToString(number, 16);

// Console.WriteLine($"{number} -> {str1}");


// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Какое количество чисел Фибоначи вывести? ");
// int num = int.Parse(Console.ReadLine()!);
// int[] array = new int[num];

// for (int i = 0; i < num; i++)
// {
//     if (i < 2) array[i] = i;
//     if (i >= 2) array[i] = array[i - 2] + array[i - 1];
// }

// Console.WriteLine($"[{String.Join(" ", array)}]");


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int size = ReadVariable("Введите размер массива: ");
// int min = ReadVariable("Введите минимальное значение элемента: ");
// int max = ReadVariable("Введите максимальное значение элемента: ");

// int[] array = GetRandomArray(size, min, max);

// Console.WriteLine($"[{String.Join(",", array)}]");

// int[] CopyArray(int[] arr)
// {
//     int[] newarr= new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         newarr[i] = arr[i];
//     }
//     return newarr;
// }

// Console.WriteLine($"[{String.Join(",", CopyArray(array))}]");


// // Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // Решить 2 способами: 1) менять числа местами в исходном массиве; 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]

// int size = ReadVariable("Введите размер массива: ");
// int min = ReadVariable("Введите минимальное значение элемента: ");
// int max = ReadVariable("Введите максимальное значение элемента: ");

// int[] array = GetRandomArray(size, min, max);

// Console.WriteLine($"[{String.Join(",", array)}]");

// int[] ReverseArray(int[] arr)
// {
//     for (int i=0;i<size/2;i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[size-i-1];
//         arr[size-i-1] = temp;
//     }
//     return arr;
// }

// int[] ReverseArraySecond(int[] arr)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = arr[size - i - 1];
//     }
//     return newArray;
// }

// Console.WriteLine($"[{String.Join(",", ReverseArraySecond(array))}]");


// -------------------------------Общие методы-------------------------------------------

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int ReadVariable(string message)
{
    Console.Write(message);
    int var = int.Parse(Console.ReadLine()!);
    return var;
}