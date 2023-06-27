// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool triangle(int a, int b, int c)
{
  if (a < b + c && b < a + c && c < a + b)
  {
    return true;
  }
  else
  {
    return false;
  }
}


System.Console.Write("Введите сторону А ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите сторону B ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите сторону C ");
int c = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(triangle(a, b, c));