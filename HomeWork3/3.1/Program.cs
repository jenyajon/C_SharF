// Задача 1: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

string Pal(int n)
{
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "Число не пятизначное";
    else
        while (num > 1)
        {
            if (n / num % 10 != n % 10)
                return "нет";
            n /=10;
            num /= 100;
        }
        return "да";
}

Console.WriteLine(Pal(int.Parse(Console.ReadLine())));
