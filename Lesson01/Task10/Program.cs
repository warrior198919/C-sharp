//Массив и Алгоритм ?Гири
int n = 5;
int[] array = { 2, 4, 24, 7, 9 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);
// Помимо Цикла while есть Цикл FOR отличие в том что это "Счетный Цикл или Перебор данных"
// пример for (int -i = 0; Инициализация i < 10; Условие  i = i + 1 Модификация)
// { 
    /// ...  ТЕЛО ЦИКЛА
//}
// Цикл FOREACH не имеет ИНДЕКСА Числа в заданном массиве for и wile присваивают Индекс [] в массиве,а foreach "КИДАЕТ/копирует" 
// цифры из массива на прямую и могут только Читаться но не изменятся
// Ниже примеры ЦИКЛОВ for и foreach (Знак "++" тоже что i = i + 1)
max = array[0];
for(int j = 0; j < n; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
//     // не требуется писать j = j + 1;
}
Console.WriteLine(max);
//FOREACH
max = array[0];
foreach(int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);