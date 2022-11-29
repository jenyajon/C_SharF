// Напишите программу, которая на вход принимает одно число (N), а на
// выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int N = int.Parse(num);
int NeN = -N;

while (NeN <= N)
{
    Console.Write($"{NeN} ");
    NeN += 1;
}