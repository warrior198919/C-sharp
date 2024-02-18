// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Первая Задача
using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"{firstNumber} больше чем {secondNumber}");
            Console.WriteLine($"{secondNumber} меньше чем {firstNumber}");
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine($"{firstNumber} меньше чем {secondNumber}");
            Console.WriteLine($"{secondNumber} больше чем {firstNumber}");
        }
        else
        {
            Console.WriteLine($"{firstNumber} равно {secondNumber}");
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}