// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int day=Convert.ToInt32(Console.ReadLine());

if (day==1)
{
  Console.Write($"день недели {day} понедельник");
}

else if (day==2)
{
  Console.Write($"день недели {day} вторник");
}
else if (day==3)
{
  Console.Write($"день недели {day} среда");
}

else if (day==4)
{
  Console.Write($"день недели {day} четверг");

}
else if (day==5)
{
  Console.Write($"день недели {day} пятница");
}
else if (day==6)
{
  Console.Write($"день недели {day} суббота");

}
else 
{
  Console.Write($"день недели {day} скорее всего воскресенье");
}
