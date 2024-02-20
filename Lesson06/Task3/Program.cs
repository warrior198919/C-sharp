class Program
{
    static void Main()
    {
        Console.Write("Введите целое число из отрезка [10, 99]: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;

            int maxDigit = (firstDigit > secondDigit) ? firstDigit : secondDigit;

            Console.WriteLine($"Наибольшая цифра числа {number}: {maxDigit}");
        }
        else
        {
            Console.WriteLine("Введенное число не соответствует диапазону [10, 99].");
        }
    }
}