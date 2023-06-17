// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите x  ");
int x = Convert.ToInt32(Console.ReadLine());
int i=1;
while (i<=x)
{
  System.Console.Write($"{Math.Pow(i,2)}, ");
  i++;
}