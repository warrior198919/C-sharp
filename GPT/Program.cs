﻿// Семинары 2 марта 2024 Андрей Булгаков
// Администратор

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max);
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],5}");
//         }
//         Console.WriteLine();
//     }
// }

// void ReplaceEvenIdxElemToSquare(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j += 2)
//         {
//             matrix[i, j] *= matrix[i, j];
//         }
//     }
// }

// int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
// PrintMatrix(array2d);

// Console.WriteLine();

// ReplaceEvenIdxElemToSquare(array2d);
// PrintMatrix(array2d);

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами 
// (0,0); (1;1) и т.д.
// Пример

// 2 3 4 3
// 4 3 4 1
// 2 9 5 4

// => 2 + 3 + 5 = 10


// int[,] CreateMarixRndInt(int rows, int colums, int min, int max)
// {
//     int[,] array = new int[rows, colums];
//     Random rnd = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(min, max);
//         }
//     }
//     return array;
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],5}");
//         }
//         Console.WriteLine();
//     }

// }

// int SummMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     int min = matrix.GetLength(0);
//     if (matrix.GetLength(1) < min) min = matrix.GetLength(1);
//     for (int i = 0; i < min; i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }

// int[,] matr = CreateMarixRndInt(7, 5, 0, 10);

// PrintMatrix(matr);
// Console.WriteLine();
// Console.WriteLine(SummMainDiagonal(matr));

// Shohruh Hakimov

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i], 4}");
//     }
// }

// int[,] CreateMarixRndInt(int rows, int colums, int min, int max)
// {
//     int[,] array = new int[rows, colums];
//     Random rnd = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(min, max);
//         }
//     }
//     return array;
// }
// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],5}");
//         }
//         Console.WriteLine();
//     }

// }

// double[] AverageRows(int[,] matrix)
// {
//     double[] array = new double[matrix.GetLength(0)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         double tempAverage = sum / matrix.GetLength(1);
//         array[i] = tempAverage;
//     }
//     return array;
// }
// int[,] matr = CreateMarixRndInt(3, 4, 0, 10);
// PrintMatrix(matr);
// Console.WriteLine();
// double[] mass = AverageRows( matr);
// PrintArray(mass);

//  3 марта 2024


// Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string GetStringFromCharArray(char[] chars)
// {
//     string str = string.Empty;

//     for (int i = 0; i < chars.Length; i++)
//     {
//         str += chars[i] + " ";
//     }
//     return str;
// }

// char[] charsArray = {'a', 'b', 'c', 'd'};
// Console.WriteLine(GetStringFromCharArray(charsArray));


// ПРИМЕР 2 (Татьяна)
// На основе символов строки (тип string) сформир    массив
// символов (тип char[]). Вывести массив на экран.

// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// Console.WriteLine("Введите текст");
// string str = Console.ReadLine()!;

// char[] chars = StringToCharArray(str);
// PrintArray(chars);

// static char[] StringToCharArray(string str)
// {
//     char[] charsArray = new char[str.Length];

//     for (int i = 0; i < charsArray.Length; i++)
//     {
//         charsArray[i] = str[i];
//     }
//     return charsArray;
// }

// void PrintArray(char[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i],3}");
//     }
// }

// Пример 2 Игорь

// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди 
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// static int GetCountVowels(string str)
// {
//     int count = 0;
//     string vowels = "aeiouy";

//     for (int i = 0; i < str.Length; i++)
//     {
//         char currentChar = str[i];
//         for (int j = 0; j < vowels.Length; j++)
//         {
//             if (vowels[j] == currentChar)
//             {
//                 count++;
//             }
//         }
//     }
//     return count;
// }


// Console.WriteLine("Введите слово");
// string str = Console.ReadLine()!;

// Console.WriteLine(GetCountVowels(str));
// using System;

using System;

class UserInputToCompileForTest
{
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        if (ValidatePosition(array, x, y))
        {
            return array[x - 1, y - 1];
        }
        else
        {
            return -1; // Значение, указывающее на отсутствие элемента
        }
    }

    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);

        return x >= 1 && x <= rowCount && y >= 1 && y <= colCount;
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        if (ValidatePosition(numbers, x, y))
        {
            int result = FindElementByPosition(numbers, x, y);
            Console.WriteLine($"Значение элемента на позиции ({x}, {y}): {result}");
        }
        else
        {
            if (x < 1 || x > numbers.GetLength(0))
            {
                Console.WriteLine("Позиция по рядам выходит за пределы массива");
            }

            if (y < 1 || y > numbers.GetLength(1))
            {
                Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            }
        }
    }
}
