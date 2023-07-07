// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumDigital(int m, int n)
{
    if (n == m)
    {
        
        return m;
    }
    return m+SumDigital (m+1,n);
    }

System.Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigital(m,n));