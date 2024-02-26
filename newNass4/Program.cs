// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

// Начальные условия:

// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

using System;
using System.Linq;

class UserInputToCompileForTest
{ 
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        return numbers.Count(number => number >= minRange && number <= maxRange);
    }
    
    public static void PrintResult(int[] array)
    {
        int minRange = 10;
        int maxRange = 90;

        int countInRange = UserInputToCompileForTest.CountItemsRange(array, minRange, maxRange);

        Console.WriteLine(countInRange); // Выводим количество элементов в отрезке
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[] array;

        if (args.Length >= 1)
        {
            string joinedArgs = string.Join(" ", args);
            array = joinedArgs.Split(", ")
                              .Select(int.Parse)
                              .ToArray();
        }
        else
        {
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
        }

        UserInputToCompileForTest.PrintResult(array);
    }
}