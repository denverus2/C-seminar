// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120\

int Multip(int num)
{
  int multip=1;
  for (int i=1; i<=num;i++)
  {
    multip=multip*i;
  }
  return multip;
}


Console.Write("Введите число  ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Multip(x));