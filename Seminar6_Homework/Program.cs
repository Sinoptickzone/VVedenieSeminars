// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите числа через пробел: ");
string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Введено {array.Length} элементов, количество положительных: {CountPositiveElements(array)}");

int CountPositiveElements(string[] arr)
{
    int count = 0;

    foreach (string el in arr)
    {
        count += int.Parse(el) > 0 ? 1 : 0;
    }
    return count;
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

// Console.Write($"Введите коэфиценты k1, b1, k2, b2 для двух прямых y = kx + b, через пробел: ");
// string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

// Console.WriteLine($"Точка пересечения: [{String.Join("; ", Intersection(array))}]");

// double[] Intersection(string[] arr)
// {
//     double[] newarr = new double[2];

//     newarr[0] = (double.Parse(arr[3]) - double.Parse(arr[1])) / (double.Parse(arr[0]) - double.Parse(arr[2]));
//     newarr[1]  = double.Parse(arr[0]) * newarr[0] + double.Parse(arr[1]);
    
//     return (newarr);
// }