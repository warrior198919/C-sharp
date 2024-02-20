class Program
{
    static void Main()
    {
        Console.Write("Введите координату X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите координату Y: ");
        double y = double.Parse(Console.ReadLine());

        if (x != 0 && y != 0)
        {
            int quadrant;

            if (x > 0 && y > 0)
            {
                quadrant = 1;
            }
            else if (x < 0 && y > 0)
            {
                quadrant = 2;
            }
            else if (x < 0 && y < 0)
            {
                quadrant = 3;
            }
            else
            {
                quadrant = 4;
            }

            Console.WriteLine($"Точка находится в {quadrant}-й координатной четверти.");
        }
        else
        {
            Console.WriteLine("Введенные координаты не соответствуют условию (X ≠ 0 и Y ≠ 0).");
        }
    }
}