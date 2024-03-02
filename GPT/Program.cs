// using System;

// class Пример
// {
//     static void Main()
//     {
//         // Создаем массив из 10 целых чисел
//         int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };

//         // Находим количество четных чисел в массиве
//         int количествоЧетных = 0;
//         foreach (int число in array)
//         {
//             if (число % 2 == 0)
//             {
//                 количествоЧетных++;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine("Количество четных чисел в массиве: " + количествоЧетных);
//     }
// }
// using System;
// using Internal;

// Console.WriteLine("Введите натуральное число N:");
// int number = Convert.ToInt32(Console.ReadLine());

// string digits = "";
// int newNumber = number;

// while (newNumber > 0)
// {
//     int digit = newNumber % 10;
//     digits = digit + (digits == "" ? "" : ",") + digits;
//     newNumber /= 10;
// }

// Console.WriteLine($"{number} => {digits}");

/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
// Console.WriteLine("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write("Введите значения массива: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
// Console.WriteLine();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n - 1; j++)
//     {
//         if (array[j] > array[j + 1])
//         {
//             int temp = array[j];
//             array[j] = array[j + 1];
//             array[j + 1] = temp;
//         }
//     }
//     Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
// }
// Console.Clear();
