﻿// Домашнее задание АВТОТЕСТ Двумерные массивы

// Задание 1

// using System;

// class UserInputToCompileForTest
// {
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         if (ValidatePosition(array, x, y))
//         {
//             return array[x - 1, y - 1];
//         }
//         else
//         {
//             return -1; // Значение, указывающее на отсутствие элемента
//         }
//     }

//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         return x >= 1 && x <= rowCount && y >= 1 && y <= colCount;
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         if (ValidatePosition(numbers, x, y))
//         {
//             int result = FindElementByPosition(numbers, x, y);
//             Console.WriteLine(result);
//         }
//         else
//         {
//             if (x < 1 || x > numbers.GetLength(0))
//             {
//                 Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             }

//             if (y < 1 || y > numbers.GetLength(1))
//             {
//                 Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             }
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {
           
//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;
            
//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }

// // ИДЕАЛЬНОЕ РЕШЕНИЕ преподователя
// //using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         return array[x - 1, y - 1];
//     }

// // // Проверка позиций на вхождение в массив
// //     public static bool ValidatePosition(int[,] array, int x, int y)
// //     {
// //         if (x <= 0 || x >= array.GetLength(0)) {
// //             Console.WriteLine("Позиция по рядам выходит за пределы массива");
// //             return false;
// //         }
// //         if (y <= 0 || y >= array.GetLength(1)) {
// //             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
// //             return false;
// //         }
// //         return true;
// //     }

// //     public static void PrintResult(int[,] numbers, int x, int y)
// //     {
// //         if (ValidatePosition(numbers, x, y)) {

// // Console.WriteLine(FindElementByPosition(numbers, x, y));
// //         }
// //     }
// // }

// // //Не удаляйте и не меняйте класс Answer!
// // class Answer
// // {
// //     public static void Main(string[] args)
// //     {   
// //         int[,] array;

// //         int x, y;

// //         if (args.Length >= 3)
// //         {
// //             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
// //             string[] rows = args[0].Split(',');

// //             int rowCount = rows.Length;
// //             int colCount = rows[0].Trim().Split(' ').Length;

// //             array = new int[rowCount, colCount];

// //             for (int i = 0; i < rowCount; i++)
// //             {
// //                 string[] rowElements = rows[i].Trim().Split(' ');

// //                 for (int j = 0; j < colCount; j++)
// //                 {
// //                     if (int.TryParse(rowElements[j], out int result))
// //                     {
// //                         array[i, j] = result;
// //                     }
// //                     else
// //                     {
// //                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
// //                         return;
// //                     }
// //                 }
// //             }

// //             // Парсинг x и y из аргументов
// //             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
// //             {
// //                 // Теперь у вас есть двумерный массив "array" и координаты x и y
// //                 UserInputToCompileForTest.PrintResult(array, x, y);
// //             }
// //             else
// //             {
// //                 Console.WriteLine("Error parsing x or y to an integer.");
// //             }
// //         }
// //         else
// //         {

// //             // Если аргументов на входе нет, используем примерный массив
// //             array = new int[,]
// //             {
// //                 {1, 2, 3, 4},
// //                 {5, 6, 7, 8},
// //                 {9, 10, 11, 12}
// //             };
// //             x = 2;
// //             y = 2;

// //             UserInputToCompileForTest.PrintResult(array, x, y);

// //         }                
// //     }
// // }


// ЗАДАНИЕ 2

// using System;

// class UserInputToCompileForTest
// {
//     public static void PrintArray(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         for (int i = 0; i < rowCount; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 Console.Write($"{array[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         int[,] newArray = new int[rowCount, colCount];

//         for (int j = 0; j < colCount; j++)
//         {
//             newArray[0, j] = array[rowCount - 1, j];
//         }

//         for (int i = 1; i < rowCount - 1; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 newArray[i, j] = array[i, j];
//             }
//         }

//         for (int j = 0; j < colCount; j++)
//         {
//             newArray[rowCount - 1, j] = array[0, j];
//         }

//         return newArray;
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         int[,] swappedArray = SwapFirstLastRows(numbers);
//         PrintArray(swappedArray);
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }

// ИДЕАЛЬНОЕ РЕШЕНИЕ ПРЕПОДОВАТЕЛЯ
// ЗАДАНИЕ 2

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

// // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(1); i++) {
//             SwapItems(array, i);
//         }
//         return array;
//     }

// // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//         int temp = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         PrintArray(SwapFirstLastRows(numbers));
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             }; 
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }

// ЗАДАНИЕ 3

// using System;

// class UserInputToCompileForTest
// {
//     public static int[] SumRows(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         int[] rowSums = new int[rowCount];

//         for (int i = 0; i < rowCount; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 rowSums[i] += array[i, j];
//             }
//         }

//         return rowSums;
//     }

//     public static int MinRowIndex(int[] array)
//     {
//         int minIndex = 0;
//         int minValue = array[0];

//         for (int i = 1; i < array.Length; i++)
//         {
//             if (array[i] < minValue)
//             {
//                 minIndex = i;
//                 minValue = array[i];
//             }
//         }

//         return minIndex;
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         int[] rowSums = SumRows(numbers);
//         int minRowIndex = MinRowIndex(rowSums);

//         Console.WriteLine(minRowIndex);
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             numbers = new int[,]
//             {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//             };
//         }

//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }

// ИДЕАЛЬНОЕ РЕШЕНИЕ ПРЕПОДОВАТЕЛЯ
// ЗАДАНИЕ 2

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {
//         int[] sum = new int[array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum[i] += array[i, j];
//             }
//         }
//         return sum;
//     }

//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
//         int minI = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[minI] > array[i])
//             {
//                 minI = i;
//             }
//         }
//         return minI;
//     }
//     public static void PrintResult(int[,] numbers)
//     {   
//         int[] sums = SumRows(numbers);
//         int minIndex = MinIndex(sums);
//         Console.Write(minIndex);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив

//             numbers = new int[,] {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//     };      
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }