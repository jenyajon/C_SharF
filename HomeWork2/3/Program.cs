// Задача 3: Напишите программу, которая выводит третью цифру
//           заданного числа или сообщает, что третьей цифры нет.

void Func(int num)
{
    Console.Write($"{num} --> ");
    if (num < 99)
    {
        Console.Write("Число не 3е число");
        return;
    }
    while (num > 999) num /=10;
    Console.WriteLine(num % 10);
}

Func(int.Parse(Console.ReadLine()));