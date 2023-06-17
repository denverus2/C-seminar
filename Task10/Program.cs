// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondFromThree(int num)
{
  int second = (num / 10) % 10;
  return (second);
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
  System.Console.WriteLine(SecondFromThree(number));

}
else
{
  System.Console.WriteLine("В трехзначном три цифры");
}