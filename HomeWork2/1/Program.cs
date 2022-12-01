// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
//           и на выходе показывает вторую цифру этого числа.

string Func(int num)
{
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "Номер не трех-значный";
}
Console.Write("Введите 3х значное число: ");
Console.WriteLine(Func(int.Parse(Console.ReadLine())));