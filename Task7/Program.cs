﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8




Console.Write("Введите трехзначное число ");
int number=Convert.ToInt32(Console.ReadLine());
if (number<99 ^ number>999) {System.Console.WriteLine("Оно не трехзначное");}
System.Console.WriteLine(number%10);

