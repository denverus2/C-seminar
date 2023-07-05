// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrixSnake(int row, int col)
{
  int[,] arr = new int[row, col];
  int x = 0;
  int y = 0;
  int xk = 1;
  int yk = 0;
  int xmax = col - 1;
  int xmin = 0;
  int ymax = row - 1;
  int ymin = 1;

  for (int i = 1; i <= row * col; i++)
  {
    arr[y, x] = i;

    if (xk == 1 && yk == 0 && (x + xk > xmax))
    {
      xk = 0;
      yk = 1;
      xmax--;
    }
    else if (xk == 0 && yk == 1 && (y + yk > ymax))
    {
      xk = -1;
      yk = 0;
      ymax--;
    }
    else if (xk == -1 && yk == 0 && (x + xk < xmin))
    {
      xk = 0;
      yk = -1;
      xmin++;
    }
    else if (xk == 0 && yk == -1 && (y + yk < ymin))
    {
      xk = 1;
      yk = 0;
      ymin++;
    }
    x = x + xk;
    y = y + yk;

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



System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());

if (row * column <= 100)
{
  int[,] matrix = FillMatrixSnake(row, column);
  PrintMatrix(matrix);
  System.Console.WriteLine();
}
else
{
  System.Console.WriteLine("давай поменьше");
}