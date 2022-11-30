// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;

if(num3 > max) max = num3;

Console.Write("Максимальное число: ");
Console.WriteLine(max);
