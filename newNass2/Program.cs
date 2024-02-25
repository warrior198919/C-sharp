// Задайте массив из N случайных целых чисел(N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 2181 4 0 912 3]
// => 2
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindResult(int end, int kratnoe, int[] arrInt)
{
    int counter = 0;
    for (int i = 0; i < arrInt.Length; i++)
    {
        if (arrInt[i] % 10 == end && arrInt[i] % kratnoe == 0) counter++;
    }
    return counter;
}

int minimum = 1;
int maximum = 100;

Console.WriteLine("Введите размер массива:");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
PrintArray(arrayMain);

Console.WriteLine(FindResult(1, 7, arrayMain));