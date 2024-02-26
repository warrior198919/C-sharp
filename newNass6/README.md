 # Знакомство с языками программирования (семинары)
## Урок 3. Массивы
Для решения данного домашнего задания вам необходимо воспользоваться сервисом автоматической проверки написанного кода.

Для того, чтобы успешно выполнить задание, необходимо перейти по каждой из представленных ссылок и решить все предложенные задачи. Будьте внимательны, количество попыток отправки кода на проверку ограничено! Вам дано 5 попыток на каждую задачу.

Прикреплять полученные решения не требуется. Итоговая оценка домашнего задания появится автоматически на платформе после решения всех задач. Полученная оценка не повлияет на получение итогового документа об обучении.

<!-- ИДЕАЛЬНОЕ РЕШЕНИЕ!
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива

    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }

    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        return max;
    }



    public static void PrintResult(double[] array)
    {

        double result = FindMax(array) - FindMin(array);
        Console.WriteLine(result);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;


        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();

            // Теперь arr содержит преобразованные в целые числа из командной строки

        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
} -->