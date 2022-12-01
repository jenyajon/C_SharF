// Задача 2: Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

string Num11(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num} ---> {num / 100 * 10 + num % 10}";
    return "Число не 3х значное";

}
Console.Write("Введите 3х значное число: ");
Console.WriteLine(Num11(int.Parse(Console.ReadLine())));
