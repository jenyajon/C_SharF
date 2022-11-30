// Напишите программу, которая на вход принимает число и выдаёт, является ли 
// число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");

int NUM = int.Parse(Console.ReadLine());

if(NUM % 2 == 0)
{
    Console.WriteLine($"Число {NUM} четное");
}
else
{
    Console.WriteLine($"Число {NUM} НЕчетное");
}