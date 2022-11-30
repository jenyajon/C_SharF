// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int N = int.Parse(num);
count = 0;


if(N == 2)
{
    Console.WriteLine("2 и все");
}

while(count == N)
{
    Console.WriteLine(count);
    count+=2;
}