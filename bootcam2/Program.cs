﻿//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Создаем массив
        int[] массив = { 6, 7, 8, 9, 10 };

        Console.WriteLine("Исходный массив:");
        ВывестиМассив(массив);

        // Переворачиваем массив
        ПеревернутьМассив(массив);

        Console.WriteLine("Массив после переворота:");
        ВывестиМассив(массив);
    }

    // Метод для переворота массива
    static void ПеревернутьМассив(int[] массив)
    {
        int начало = 0;
        int конец = массив.Length - 1;

        while (начало < конец)
        {
            // Обмен значений элементов на начале и конце массива
            int временное = массив[начало];
            массив[начало] = массив[конец];
            массив[конец] = временное;

            // Перемещаемся к следующим элементам
            начало++;
            конец--;
        }
    }

    // Метод для вывода массива на экран
    static void ВывестиМассив(int[] массив)
    {
        foreach (int число in массив)
        {
            Console.Write(число + " ");
        }
        Console.WriteLine();
    }
}