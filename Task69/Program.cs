// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowRec(int a, int b)
{
  if (b==0)
  {
    return 1;
  }
  return a*PowRec(a,b-1);
}


System.Console.Write("Введите A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(PowRec(a,b));