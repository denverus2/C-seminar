// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double DiffMinMax(double[] arr)
{
  double min = arr[0];
  double max = arr[0];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] < min)
    {
      min = arr[i];
    }
    if (arr[i] > max)
    {
      max = arr[i];
    }
  }
  return max-min;

}



double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };
System.Console.WriteLine($"Разница между мин и макс в массиве {DiffMinMax(array)}");
