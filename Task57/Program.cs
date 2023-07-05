// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] FillMatrixWithRandom(int row, int col)
{
  int[,] arr = new int[row, col];
  Random rnd = new Random();
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      arr[i, j] = rnd.Next(0, 10);
    }

  }
  return arr;
}

void PrintMatrix(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} \t");
    }
    System.Console.WriteLine();

  }
}

int[] IntCount(int[,] arr)
{
  int[] countArr = new int[10];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      countArr[arr[i, j]]++;
    }

  }
  return countArr;
}

System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
int [] count = IntCount(matrix);
for (int i = 0; i < 10; i++)
{
  if (count[i]>0)
  {
    System.Console.WriteLine($"Число {i} встречается {count[i]} раз.");
  }

}