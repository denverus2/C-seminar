// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int numberA=Convert.ToInt32(Console.ReadLine());


Console.Write("Введите второе число: ");
int numberB=Convert.ToInt32(Console.ReadLine());

if (numberA==numberB*numberB)
{
  Console.Write($"Первое число {numberA } равно Квадрату второго {numberB}");

}
else
{
  Console.Write($"Первое число {numberA } не равно Квадрату второго {numberB}");
}