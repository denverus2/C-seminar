﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>0&&number<8)
{
  if (number==6||number==7)
  {
    System.Console.WriteLine("Выходной");
  }
  else
  {
    System.Console.WriteLine("Арбайтен унд дисциплинен!");
  }

}
else
{
System.Console.WriteLine("В неделе 7 дней");
}