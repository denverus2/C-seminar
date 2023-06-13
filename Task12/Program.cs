
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите x: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1%number2==0)
{
  System.Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
  System.Console.WriteLine($"Остаток от деления числа {number1} на число  {number2} - {number1%number2}");
}