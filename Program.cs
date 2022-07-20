// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();

//         double[,] GetArray(int m, int n, int minValue, int maxValue)
//         {
//             double[,] result = new double [m, n];
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     result [ i, j] = new Random().NextDouble()*(maxValue-minValue)+minValue;

//                 }
//             }
//             return result;
//         }

//         void PrintArray(double[,] inArray)
//         {
//             for (int i = 0; i < inArray.GetLength(0); i++)
//             {
//                 for (int j = 0; j < inArray.GetLength(1); j++)
//                 {
//                     Console.Write($"{inArray[i, j]:f2} ");
//                 }
//                 Console.WriteLine();
//             }
//         }

//         Console.Write("Введите количество строк массива: ");
//         int rows = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите количество столбцов массива: ");
//         int columns = Convert.ToInt32(Console.ReadLine());

//         double[,] array = GetArray(rows, columns, -10, 10);
//         PrintArray(array);
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();

//         int[,] GetArray(int m, int n, int minValue, int maxValue)
//         {
//             int[,] result = new int[m, n];
//             for (int i = 0; i < m; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     result[i, j] = new Random().Next(minValue, maxValue + 1);
//                 }
//             }
//             return result;
//         }

//         void PrintArray(int[,] inArray)
//         {
//             for (int row = 0; row < inArray.GetLength(0); row++)
//             {
//                 for (int column = 0; column < inArray.GetLength(1); column++)
//                 {
//                     Console.Write($"{inArray[row, column]} ");
//                 }
//                 Console.WriteLine();
//             }
//         }

//         Console.Write("Введите индекс номера строки массива: ");
//         int row = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите индекс номера столбца массива: ");
//         int column = Convert.ToInt32(Console.ReadLine());
//         int[,] array = GetArray(9, 9, 0, 99);
//         PrintArray(array);
//         Console.WriteLine("----------");
//         if (row <= 8 && column <= 8)
//         {
//             Console.Write(array[row, column]);
//         }
//         else
//         {
//             Console.WriteLine("Элемент находится за пределами массива.");
//         }
//     }
// }