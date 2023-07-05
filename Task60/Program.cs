// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillMatrixWithRandom3d(int row, int col, int depth)
{
  int[,,] arr = new int[row, col, depth];
  int[] exist = new int[90];
  Random rnd = new Random();
  int ex = 1;
  
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < col; j++)
    {
      for (int k = 0; k < depth; k++)
      {
        while (ex == 1)
        {
          arr[i, j, k] = rnd.Next(10, 100);
          if (exist[arr[i, j, k] - 10] == 0)
          {
            exist[arr[i, j, k] - 10] = 1;
            ex = 0;
          }
          

        }
        ex = 1;
      }

    }

  }
  
  return arr;
}

void PrintMatrix3d(int[,,] matrix)
{
  for (int k = 0; k < matrix.GetLength(2); k++)
  {
    System.Console.WriteLine($"Слой {k}:");
    System.Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        System.Console.Write($"{matrix[i, j, k]} \t");
      }
      System.Console.WriteLine();

    }
  }
}




System.Console.Write("Сколько строк? ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько колонок? ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сколько слоев? ");
int depth = Convert.ToInt32(Console.ReadLine());
if (row * column * depth <= 90)
{
  int[,,] matrix = FillMatrixWithRandom3d(row, column, depth);
  PrintMatrix3d(matrix);
  System.Console.WriteLine();
}
else
{
  System.Console.WriteLine("нам не хватит чисел");
}