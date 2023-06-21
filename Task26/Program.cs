// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int NumLenght (int num)
{
  string x1=Convert.ToString(num);
  return x1.Length;

}


Console.Write("Введите число  ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NumLenght (x));

