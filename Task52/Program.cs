// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[] AverageInColumn(int[,] arr)
{
  double[] average = new double[arr.GetLength(1)];
  double sum = 0;
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    sum = 0;

    for (int j = 0; j < arr.GetLength(0); j++)
    {
      sum = sum + arr[j, i];
    }
    average[i] = Math.Round(sum / arr.GetLength(0),2);

  }
  return average;

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

System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine(string.Join("\t",AverageInColumn(matrix)));