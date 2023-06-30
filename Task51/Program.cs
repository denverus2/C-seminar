// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной 


void FillMatrixWithRandom(int[,] matrix)
{
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 10);
    }

  }
}
void PrintMatrix(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();

  }
}
void MatrixCenterSum(int[,] matrix)
{
  int sum = 0;
  int iMax = matrix.GetLength(1);
  if (matrix.GetLength(0) > matrix.GetLength(1))
  {
    iMax = matrix.GetLength(0);
  }


  for (int i = 0; i < iMax; i++)
  {
    sum = sum + matrix[i, i];
  }
  System.Console.WriteLine($"Сумма элементров цент диагонали: {sum}");
}


System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];

FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
MatrixCenterSum (matrix);