// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] RandArr(int num, int min, int max)
{
  int[] arr = new int[num];
  for (int i = 0; i < num; i++)
  { 
    arr[i]=new Random().Next(min, max+1);
  
  }
  return arr;

}
Console.Write("Введите количество значений в массиве  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное:  ");
int minx = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное: ");
int maxx = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(string.Join(", ",RandArr(x,minx,maxx)));