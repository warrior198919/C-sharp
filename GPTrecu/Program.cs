﻿//Задайте значение N Напишите программу которая выведет все натуральные числа 
//в промежутке от 1 до N
//Притмер N= => 1 2 3 4 5 

Console.Clear();
void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);