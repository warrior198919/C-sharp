﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 7 == 0 && a % 23 == 0)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}