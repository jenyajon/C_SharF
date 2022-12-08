// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой 
// находится эта точка.

void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("x = 0 or y = 0");
    else if (x > 0 && y > 0)
        Console.WriteLine("I четверть");
    else if (x < 0 && y > 0)
        Console.WriteLine("II четверть");
    else if (x > 0 && y < 0)
        Console.WriteLine("III четверть");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV четверть");

}

Quarters(1, 9);
