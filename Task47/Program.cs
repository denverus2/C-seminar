// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillMatrixWithRandomFloat(int row, int col)
{
  double[,] arr = new double[row, col];
  Random rnd = new Random();
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      arr[i, j] = Math.Round(rnd.NextDouble()*200-100,2);
    }

  }
  return arr;
}


void PrintMatrixDouble(double[,] matrix)
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

System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = FillMatrixWithRandomFloat(row, column);
PrintMatrixDouble(matrix);