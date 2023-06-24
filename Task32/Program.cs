// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] Reverse (int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
      arr[i] = -arr[i];
  }
 return arr; 
}



int[] arr = {-4, -8, 8, 2};
System.Console.WriteLine(string.Join(";",Reverse(arr)));
