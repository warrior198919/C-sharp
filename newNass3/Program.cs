// Заполните массив на N (вводится с консоли, не более 8)случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший –на последнем.
// Пример
// [1 3 2 4 2 3]=> 132423
// [2 3 1]=> 231

int ArrayToInteger(int[] array)
{
    int number = 0;

    for (int i = 0; i < array.Length; i++)
    {
        number = number * 10 + array[i];
    }
    return number;
}

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


int minimum = 0;
int maximum = 10;

Console.WriteLine("Введите размер массива:");
int count = Convert.ToInt32(Console.ReadLine());

int[] arrayMain = CreateArrayRndInt(count, minimum, maximum);
PrintArray(arrayMain);

Console.WriteLine(ArrayToInteger(arrayMain));