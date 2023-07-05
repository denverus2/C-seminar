// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 

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

int[,] MatrixRotate(int[,] arr)
{
  int[,] newArr = new int[arr.GetLength(1), arr.GetLength(0)];
  for (int i = 0; i < newArr.GetLength(0); i++)
  {
    for (int j = 0; j < newArr.GetLength(1); j++)
    {
      newArr[i, j] = arr[j, i];
    }

  }
  return newArr;
}


System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(MatrixRotate(matrix));
System.Console.WriteLine();
PrintMatrix(matrix);