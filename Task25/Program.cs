﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int a, int b)
{
  int result = 1;
  for (int i = 1; i <= b; i++)
  {
    result = result * a;


  }
  return result;

}




Console.Write("Введите основание ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Power(x1, y1));