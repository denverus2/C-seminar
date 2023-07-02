// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


double[,] FillMatrixWithRandomFloat(int row, int col)
{
  double[,] arr = new double[row, col];
  Random rnd = new Random();
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      arr[i, j] = Math.Round(rnd.NextDouble() * 200 - 100, 2);
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


double[,] matrix = FillMatrixWithRandomFloat(10, 10);
PrintMatrixDouble(matrix);

System.Console.Write("Какая строка? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("какая колонка? ");
int column = Convert.ToInt32(Console.ReadLine());

if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
{
  System.Console.WriteLine($"matrix [{row}, {column}] = {matrix[row, column]}");
}
else
{
  System.Console.WriteLine("Таких координат в массиве нет");
}