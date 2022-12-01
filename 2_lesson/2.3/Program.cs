// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23.

string Func(int num)
{
if(num % 7 == 0)
return $"Число {num} кратное 7";
else
return $"Число {num} не кратное и имеет остаток от 7: {num % 7}";
if(num % 23 == 0)
return $"Число {num} кратное 23";
else
return $"Число {num} не кратное и имеет остаток от 23 {num % 23}";
}
Console.Write("Введите число для проверки:");
int nuu = int.Parse(Console.ReadLine());


Console.WriteLine(Func(nuu));