// Задача 1: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);

    return array;
}

int EvenNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    return count;
}

int[] array_1 = MassNums(int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()));
Print(array_1);
Console.WriteLine(EvenNum(array_1));