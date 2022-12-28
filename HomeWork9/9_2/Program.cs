// Задача 2: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int N, int M)
{
    if(N > M)
        return 0;
    return N + Sum(N + 1, M);
}
System.Console.WriteLine(Sum(1,15));