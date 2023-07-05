// Задача 53: Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.

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

int[,] MatrixChangeFirstLast(int [,] arr)
{
  int  temp = 0;
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    temp=arr[0,i];
    arr[0,i]=arr[arr.GetLength(0)-1,i];
    arr[arr.GetLength(0)-1,i]=temp;
  
  }
  return arr;
}


System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
System.Console.WriteLine();
int [,] newMatrix = MatrixChangeFirstLast (matrix);
PrintMatrix(newMatrix);
System.Console.WriteLine();
PrintMatrix(matrix);