// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

double Func(float x1, float y1, float z1, float x2, float y2, float z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}

Console.WriteLine(Func(4, 3, 2, -1, 7, 4));
Console.WriteLine(Func(6, 3, 7, 16, -10, 2));