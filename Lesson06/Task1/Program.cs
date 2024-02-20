class Program {
    static void Main() {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        bool isMultipleOf7And23 = (number % 7 == 0) && (number % 23 == 0);

        if (isMultipleOf7And23) {
            Console.WriteLine($"{number} кратно и 7, и 23.");
        } else {
            Console.WriteLine($"{number} не кратно одновременно 7 и 23.");
        }
    }
}