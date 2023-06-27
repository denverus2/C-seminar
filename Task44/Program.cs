// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonachi(int a)
{
  int[] fibonachi = new int[a];
  if (a == 1)
  {
    fibonachi[0] = 0;
    return fibonachi;
  }
  else
  {
    fibonachi[0] = 0;
    fibonachi[1] = 1;
    for (int i = 2; i < a; i++)
    {
      fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
    }
    return fibonachi;
  }
}

System.Console.Write("Сколько чисел нужно? ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
{
  System.Console.WriteLine(string.Join(", ", Fibonachi(a)));
}
else
{
  System.Console.WriteLine("Что то пошло не так");
}

