// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>9999&&number<100000)
{
  if (number/10000==number%10 && ((number/1000)%10)==(number/10)%10)
  {
    System.Console.WriteLine($"Число {number} полиндром");
  }
  else
  {
    System.Console.WriteLine($"Число {number} не полиндром");
  }

}

else
{
  System.Console.WriteLine("Обычно в пятизначном числе 5 цифр. Давайте примем это за аксиому");
}