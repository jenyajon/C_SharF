// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B. Без модуля Math, используем цикл for.

double Func(int a, int b)
{
    double n_pow = 1;
    int b_abs = Math.Abs(b);

    for (int i = 1; i<=b_abs; i++)
    {
        if (b > 0);
            n_pow *=a;
        else
            n_pow /=a;
    }
    return n_pow;
}

Console.WriteLine("Введите число: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(Func(num_1, num_2));