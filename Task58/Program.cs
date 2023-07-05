// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultipleMatrix(int[,] arr1, int[,] arr2)
{
  int[,] multArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
  
  for (int i = 0; i < multArr.GetLength(0); i++)
  {
    for (int j = 0; j < multArr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arr1.GetLength(1); k++)
      {
         sum += arr1[i, k] * arr2[k, j];
      }
      multArr[i, j] = sum;
    }

  }
  return multArr;
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


System.Console.Write("Сколько строк в первой матрице? ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок в первой ? ");
int column1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Сколько строк во второй матрице? ");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок вовторой ? ");
int column2 = Convert.ToInt32(Console.ReadLine());


int[,] matrix1 = FillMatrixWithRandom(row1, column1);
PrintMatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = FillMatrixWithRandom(row2, column2);
PrintMatrix(matrix2);
System.Console.WriteLine();

if (matrix1.GetLength(1)==matrix2.GetLength(0))
{
  int [,]multMatrix = MultipleMatrix(matrix1,matrix2);
  PrintMatrix(multMatrix);

}
else
{
  System.Console.WriteLine("Матрицы несогласованы");
}