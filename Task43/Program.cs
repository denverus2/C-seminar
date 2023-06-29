// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] PointOfTouch(double b1, double k1, double b2, double k2)

{
  double[] arr = new double[2];
  arr[0] = (b2 - b1) / (k1 - k2);
  arr[1] = k1 * arr[0] + b1;
  return arr;
}

System.Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
System.Console.WriteLine("Введите b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(string.Join(",", PointOfTouch(b1, k1, b2, k2)));