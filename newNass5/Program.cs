﻿// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6
using System;
using System.Linq;

// Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class ArrayProcessor
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        int количествоЧетных = 0;

        foreach (int число in numbers)
        {
            if (число % 2 == 0)
            {
                количествоЧетных++;
            }
        }

        return количествоЧетных;
    }
    
    public static void PrintResult(int[] array)
    {
        int количествоЧетных = CountEvenItems(array);

        Console.WriteLine(количествоЧетных);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;

        if (args.Length >= 1)
        {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                              .Select(int.Parse)
                              .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        }
        else
        {
            // Если аргументов на входе нет
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }

        ArrayProcessor.PrintResult(array);
    }
}