// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadToNumber(int number)
{
    if (number == 1)
    {
        System.Console.Write("1 ");
        return;
    }
    System.Console.Write($"{number} ");
    RoadToNumber(number - 1);
    
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToNumber(number);