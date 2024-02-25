// int n = 10;
int[] array = { 1, 3, 8, 11, 9, 35, 12, 89, 7, 67 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.WriteLine($"{array[i]} ");
    }
    i = i + 1;
}