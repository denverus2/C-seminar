// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] MultiArr(int[] arr)
{

  int[] arrtemp = new int[arr.Length / 2 + arr.Length % 2];



  for (int i = 0; i < arr.Length / 2; i++)
  {
    arrtemp[i] = arr[i] * arr[arr.Length - i - 1];
  }
  if (arr.Length % 2 == 1)
  {
    arrtemp[arrtemp.Length - 1] = arr[arrtemp.Length - 1];
  }

  return arrtemp;

}



int[] x1 = { 1, 3, 4, 5 };
int[] x2 = { 6, 7, 3, 6, 7 };

System.Console.WriteLine(string.Join("; ", x1));
System.Console.WriteLine(string.Join("; ", MultiArr(x1)));
System.Console.WriteLine(string.Join("; ", x2));
System.Console.WriteLine(string.Join("; ", MultiArr(x2)));