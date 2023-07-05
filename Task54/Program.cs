// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowMatrix(int[,] matrix)
{
  int temp = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {

    for (int j = 0; j <matrix.GetLength(1)-1; j++)
    {
      for (int k = matrix.GetLength(1)-1; k > j; k--)
      {
        if (matrix[i, k] > matrix[i, k - 1])
        {
          
          temp = matrix[i, k];
          matrix[i, k] = matrix[i, k - 1];
          matrix[i, k - 1] = temp;
        }
      }
      
    }
  }
}

System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
SortRowMatrix(matrix);
PrintMatrix(matrix);