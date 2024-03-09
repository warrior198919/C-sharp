// Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l 
//“World” => W r l d 
//“Hello world!” => H l l w r l d

Console.Clear();
void ShowConsonats(string str)
{
    string vowels = "aeiouy";
    if (str.Length == 0) return;

    if (!vowels.Contains(str[0]))
    {
        Console.WriteLine($"{str[0]} ");
    }
    ShowConsonats(str.Substring(1));
}

Console.WriteLine("Введите текст латинскими буквами:");
string str = Console.ReadLine();

ShowConsonats(str);


// void ShowConsonants(string str)
// {
//     string vowels = "aeiouy";
//     if (str.Length == 0) return;
     
//     if (!vowels.Contains(str[0]))
//     {
//         Console.Write($"{str[0]} ");
//     }
//    ShowConsonants(str.Substring(1));
// }

// Console.WriteLine("Введите текст латинскими буквами:");
// string str = Console.ReadLine();

// ShowConsonants(str);