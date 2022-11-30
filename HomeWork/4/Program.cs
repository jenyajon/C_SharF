// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string num = Console.ReadLine();
int N = int.Parse(num);
int count = 2;

while(count <= N)
{
    Console.WriteLine(count);
    count += 2;
}