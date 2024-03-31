﻿using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число (для завершения введите 'q'): ");
            
            // Используем string? для явного указания, что переменная может быть null
            string? ввод = Console.ReadLine();

            // Проверка на 'q' для завершения программы
            if (string.Equals(ввод, "q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Проверка на null после вызова Console.ReadLine()
            if (ввод == null)
            {
                Console.WriteLine("Ошибка при чтении ввода. Программа завершена.");
                break;
            }

            // Преобразование введенной строки в нижний регистр
            ввод = ввод.ToLower();

            // Попытка преобразовать введенную строку в целое число
            if (int.TryParse(ввод, out int число))
            {
                // Проверка суммы цифр числа на четность
                if (СуммаЦифрЧетная(число))
                {
                    Console.WriteLine($"Сумма цифр числа {число} четная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {число} нечетная.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для завершения.");
            }
        }
    }

    static bool СуммаЦифрЧетная(int число)
    {
        int сумма = 0;

        while (число != 0)
        {
            сумма += число % 10;
            число /= 10;
        }

        return сумма % 2 == 0;
    }
}

//Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная