// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Auf(int N)
{
int i = 0;
double sum;
while (i < N )
{
i += 1;
if (i == (N))
{
sum = Math.Pow(i,3);
Console.Write($"{sum}");
}
else
{

sum = Math.Pow(i,3);
Console.Write($"{sum},");
}
}

}
Console.WriteLine("введите число");
int chislo = int.Parse(Console.ReadLine());
Auf(chislo);