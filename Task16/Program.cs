// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool truekvadrat(int x, int y)
{
  if (x * x == y || y * y == x)
  {
    return true;
  }
  else
  {
    return false;
  }
}


Console.Write("Введите x: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(truekvadrat(number1, number2));

