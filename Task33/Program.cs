// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

bool FindElem (int[] arr, int x)
{
  for (int i = 0; i < arr.Length; i++)
  {
      if (arr[i]==x)
      {
        return true;
      }
  }
 return false; 
}



int[] arr = {6, 7, 19, 345, 3};
Console.Write("Что ищем?  ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindElem(arr,x));