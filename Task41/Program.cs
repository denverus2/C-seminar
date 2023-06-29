// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArr(int m)
{

  int[] array = new int[m];
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write($"{i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}
int IsPositive(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length - 1; i++)
  {
    if (arr[i] > 0)
    {
      count++;
    }


  }
  return count;
}



System.Console.WriteLine("Сколько чисел вводим?:");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArr(m);
System.Console.WriteLine($"Чисел больше нуля: {IsPositive(arr)}");
