// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// Начальные условия:int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};// Создание массива Выводится: 5.15

using System;
using System.Linq;

class UserInputToCompileForTest
{
    public static double FindMin(double[] numbers)
    {
        return numbers.Min();
    }

    public static double FindMax(double[] numbers)
    {
        return numbers.Max();
    }

    public static void PrintResult(double[] array)
    {
        double min = FindMin(array);
        double max = FindMax(array);
        double difference = max - min;

        Console.WriteLine($"{difference:G}");
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        double[] array;

        if (args.Length >= 1)
        {
            string joinedArgs = string.Join(" ", args);
            array = joinedArgs.Split(", ")
                              .Select(double.Parse)
                              .ToArray();
        }
        else
        {
            array = new double[] { 5.4, 0.25, 1.3, 2.1, 4.8, 5.2, 3.01 };
        }

        UserInputToCompileForTest.PrintResult(array);
    }
}

// ПЕРВОНАЧАЛЬНЫЙ вариант НИЖЕ:
// Этот код использует форматированную строку "{difference:F2}", чтобы выводить разницу с двумя знаками после запятой.
// Правильный Вариант ВЫШЕ(!) где учтена (исправленна) ошибка%
// Понял вас. В этом случае, чтобы избежать вывода нулевого десятичного разряда, вы можете использовать спецификатор формата G вместо F. Вот исправленный код:


// using System;
// using System.Linq;

// class UserInputToCompileForTest
// { 
//     public static double FindMin(double[] numbers)
//     {
//         return numbers.Min();
//     }
    
//     public static double FindMax(double[] numbers)
//     {
//         return numbers.Max();
//     }
    
//     public static void PrintResult(double[] array)
//     {
//         double min = FindMin(array);
//         double max = FindMax(array);
//         double difference = max - min;

//         Console.WriteLine($"{difference:F2}");
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;

//         if (args.Length >= 1)
//         {
//             string joinedArgs = string.Join(" ", args);
//             array = joinedArgs.Split(", ")
//                               .Select(double.Parse)
//                               .ToArray();
//         }
//         else
//         {
//             array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
//         }

//         UserInputToCompileForTest.PrintResult(array);
//     }
// }