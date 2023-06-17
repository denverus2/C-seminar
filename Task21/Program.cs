// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// AB = √(xb - xa)2 + (yb - ya)2

Console.Write("Введите x первой точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y первой точки ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите x второй точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y второй точки ");
int y2 = Convert.ToInt32(Console.ReadLine());

double ab = Math.Round (Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)),2);

System.Console.WriteLine(ab);
