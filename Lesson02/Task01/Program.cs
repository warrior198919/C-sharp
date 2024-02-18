// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Первая Задача
using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        string result = (firstNumber > secondNumber) ? "больше" : (firstNumber < secondNumber) ? "меньше" : "равно";
        Console.WriteLine($"{firstNumber} {result} чем {secondNumber}");
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
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}