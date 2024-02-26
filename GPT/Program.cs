// using System;

// class Пример
// {
//     static void Main()
//     {
//         // Создаем массив из 10 целых чисел
//         int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };

//         // Находим количество четных чисел в массиве
//         int количествоЧетных = 0;
//         foreach (int число in array)
//         {
//             if (число % 2 == 0)
//             {
//                 количествоЧетных++;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine("Количество четных чисел в массиве: " + количествоЧетных);
//     }
// }
// using System;
// using Internal;

Console.WriteLine("Введите натуральное число N:");
int number = Convert.ToInt32(Console.ReadLine());

string digits = "";
int newNumber = number;

while (newNumber > 0)
{
    int digit = newNumber % 10;
    digits = digit + (digits == "" ? "" : ",") + digits;
    newNumber /= 10;
}

Console.WriteLine($"{number} => {digits}");