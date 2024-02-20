class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            Console.Write($"Цифры числа {n} через запятую: ");

            // Преобразование числа в строку для посимвольного доступа
            string numberAsString = n.ToString();

            // Вывод цифр через запятую
            for (int i = 0; i < numberAsString.Length; i++)
            {
                Console.Write(numberAsString[i]);
                if (i < numberAsString.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Введенное число не является натуральным.");
        }
    }
}