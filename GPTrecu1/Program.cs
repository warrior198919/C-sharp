// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

Console.Clear();
int SumNumbers(int number) //123 12 1 0
{
    if (number == 0) return 0;
    return number % 10 + SumNumbers(number / 10); //123 12 1
}

Console.WriteLine(SumNumbers(123));