// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

void Print(double[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] array = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        array[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);

    return array;
}
    void DiffMaxMin(double[] array)
    {
        double n_max = array[0];
        double n_min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (n_max < array[i])
                n_max = array[i];

            else if (n_min > array[i])
                n_min = array[i];
        }
    

    Console.Write($"Max: {n_max}, min: ({n_min}), ");
    Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
    }

    double[] array_1 = MassNums(int.Parse(Console.ReadLine()),
                                int.Parse(Console.ReadLine()),
                                int.Parse(Console.ReadLine()));

Print(array_1);
DiffMaxMin(array_1);