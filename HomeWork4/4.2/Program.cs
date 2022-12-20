// Задача 2: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

int Func(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num /=10;
    }
    return sum;
}

Console.WriteLine(Func(int.Parse(Console.ReadLine()))); 