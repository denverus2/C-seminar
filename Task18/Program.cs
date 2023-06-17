// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


string[] abs= {"Первая x>0, y>0", "Вторая x<0, y>0", "Третья x<0 y<0", "Четвертая x>0, y<0"};
Console.Write("Введите четверть ");
int x = Convert.ToInt32(Console.ReadLine());
if (x>0&&x<5)
{
System.Console.WriteLine(abs[x-1]);
}
else
{
System.Console.WriteLine("Четвертей четыре");
}