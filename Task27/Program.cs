// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// -452 = 3


int NumSum(int num)
{
  string x1 = Convert.ToString(num);
  int sum = 0;
  if (num >= 0)
  {


    string c;
    for (int i = 0; i < x1.Length; i++)
    {
      c = Convert.ToString(x1[i]);

      sum = sum + Convert.ToInt32(c);


    }
  }
  else
  {

    sum = Convert.ToInt32(Convert.ToString(x1[1]))*-1;
    string c;
    for (int i = 2; i < x1.Length; i++)
    {
      c = Convert.ToString(x1[i]);

      sum = sum + Convert.ToInt32(c);

    }
  }
  return sum;
}


Console.Write("Введите число  ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NumSum(x));
