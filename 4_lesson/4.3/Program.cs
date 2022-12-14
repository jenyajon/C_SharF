// 3. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

void Func(int N)
{
    int[] massiv = new int[N];
    for (int i = 0; i < N; i++)
    {
        massiv[i] = new Random().Next(2);
        Console.Write($"{massiv[i]}, ");
    }
}

Console.WriteLine("Введите число:");
Func(int.Parse(Console.ReadLine()));