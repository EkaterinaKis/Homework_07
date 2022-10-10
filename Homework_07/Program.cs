// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// Console.WriteLine("Введите кол-во строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите кол-во столбцов: ");
// int columns =int.Parse(Console.ReadLine()!);

// int[,] array =GetArray(rows, columns, -100,100);
// PrintArray(array);



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// Console.WriteLine("Введите кол-во строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, -100, 100);
// PrintArray(array);

// Console.WriteLine("Укажите строку искомого элемента: ");
// int rows2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Укажите столбец искомого элемента: ");
// int columns2 = int.Parse(Console.ReadLine()!);

// if (rows2 >= rows | columns2 >= columns)
// {
//     Console.WriteLine("Данной позиции в массиве нет");
// }
// else
// {
// int num = NewGetArray(array);
// Console.WriteLine($"Число находящееся на данной позиции: {num}");
// }
// int NewGetArray(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == rows2 && j == columns2)
//             {
//                 result = array[i, j];
//             }
//         }
//     }
//     return result;
// }




//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
//0 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите кол-во строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите кол-во столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, -100, 100);
// PrintArray(array);
// Console.WriteLine("Среднее арифметическое: ");
// double average = FindAverage(array, rows);

// double FindAverage(int[,] array, int rows)
// {
//     double sum = 0;
//     double res = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             {
//                 sum += array[i, j];
//             }
//         }
//         res = sum / rows;
//         Console.Write($"{Math.Round(res, 1)}\t");
//         sum = 0;
//     }
//     return res;
// }



int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(MinValue, MaxValue);
            }
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}