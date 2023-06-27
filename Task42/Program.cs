// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string DecToBin (int a)
{
  string bin = string.Empty;
  while (a>=1)
  {
    bin=bin+Convert.ToString(a%2);
    System.Console.WriteLine(a);
    a=a/2;
  }

    char[] charArray = bin.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}




System.Console.Write("Введите чисто в десятичной: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(DecToBin(a));
