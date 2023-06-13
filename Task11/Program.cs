// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DigitCrop (int num1)
{
  int digit1=num1/100;
  int digit3=num1%10;
  return digit1*10+digit3;

}



int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.WriteLine($"Число {number} после обрезания - {DigitCrop(number)}");