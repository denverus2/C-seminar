// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите x: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
  System.Console.WriteLine("Ноль число четное");

}
else if (number % 2 == 1 ^ number % 2 == -1)
{
  System.Console.WriteLine($"{number} число нечетное");
}
else
{
  System.Console.WriteLine($"{number} число четное");
}