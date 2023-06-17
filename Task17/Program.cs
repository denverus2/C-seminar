// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
void PrintQuater(int x, int y)
{
  if (x>0&&y>0)
  {
    System.Console.WriteLine("Точка в первой четверти");
  }
  else if (x<0&&y>0)
  {
    System.Console.WriteLine("Точка во второй четверти");
  }
  else if (x<0&&y<0)
  {
    System.Console.WriteLine("Точка в третьей четверти");
  }
  else if (x>0&&y<0)
  {
    System.Console.WriteLine("Точка в четвертой четверти");

  }
}



Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
PrintQuater(x,y);