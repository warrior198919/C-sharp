﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class Answer {
    
  static int FindMax(int a, int b, int c)
    {
        // Введите свое решение ниже
        int max = Math.Max(a, Math.Max(b, c));
        return max;


    }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args) {
        int a, b, c;

        if (args.Length >= 3) {
           a = int.Parse(args[0]);
           b = int.Parse(args[1]);
           c = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           a = 5;
           b = 6;
           c = 7;
        }

        // Не удаляйте строки ниже
        int result = FindMax(a, b, c);
        System.Console.WriteLine($"{result}");
    }
}