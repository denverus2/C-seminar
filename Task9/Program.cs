int DigitCompare(int num)
{
  int digit1 = num / 10;
  int digit2 = num % 10;
  if (digit1 > digit2)
  {
    return digit1;
  }
  else
  {
    return digit2;
  }
}



int number = new Random().Next(10, 100);
System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.WriteLine($"максимальная цифра числа {number} - {DigitCompare(number)}");

