﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RandArr(int num)
{
  int[] arr = new int[num];
  for (int i = 0; i < num; i++)
  { 
    arr[i]=new Random().Next(0, 2);
  
  }
  return arr;

}

System.Console.WriteLine(string.Join(", ",RandArr(8)));