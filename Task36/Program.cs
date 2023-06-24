// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumber(int size)
{
  int[] arr = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(0, 100);
  }
  return arr;
}

int EvenArrSum(int[] arr)
{
  int sum=0;

  for (int i = 1; i < arr.Length; i=i+2)
  {
    sum=sum+arr[i];
  }
  return sum;


}




System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
System.Console.WriteLine($"Сумма нечетных {EvenArrSum(array)}");
