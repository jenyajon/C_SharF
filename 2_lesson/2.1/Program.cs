// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

int Func(int num)
{
    Console.WriteLine(num);
    return num %10;
}
Console.WriteLine(Func(new Random().Next(100, 1000)));
