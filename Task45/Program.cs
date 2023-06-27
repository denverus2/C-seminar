//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] arr)
{
  int[] newArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++)
  {
    newArr[i] = arr[i];
  }
  return newArr;

}


System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
System.Console.WriteLine(string.Join("; ", CopyArray(array)));