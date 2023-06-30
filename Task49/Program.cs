// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


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
void MatrixEvenSqrt (int[,] matrix)
{
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i=i+2)
  {
    for (int j = 0; j < matrix.GetLength(1); j=j+2)
    {
      matrix[i, j] =matrix [i,j]*matrix [i,j];
    }

  }
}


System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];

FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
MatrixEvenSqrt (matrix);
System.Console.WriteLine();
PrintMatrix(matrix);