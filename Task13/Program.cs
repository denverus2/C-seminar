// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdCifr(int num)
{
  while (num>=1000)
  {
    num/=10;
  }
  int result = num %10;
  return(result);

}



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0)
{
  number=-number;
}
if (number>100)
{
  System.Console.WriteLine(ThirdCifr(number));
}
else
{
  System.Console.WriteLine("Число маловато");
}
