// Задача 1: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

void Func(int N)
{
    int i = 0;
    int sum = 0;
    while (i <= N)
    {
        sum = sum + i;
        i += 1;
    }
    Console.Write($"{sum} ");
}

Console.Write("введите число: ");
int chislo = int.Parse(Console.ReadLine());
Func(chislo);
