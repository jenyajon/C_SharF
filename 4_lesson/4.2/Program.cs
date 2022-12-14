// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

int Func(int N)
{
    int sum = 1;
    for (int i = 1; i <= N; i++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.Write("Введите число: ");
Console.WriteLine(Func(int.Parse(Console.ReadLine())));