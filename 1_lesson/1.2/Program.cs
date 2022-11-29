// Напишите программу, которая будет
// выдавать название дня недели по заданному номеру.

Console.WriteLine("Add number week");
int s = int.Parse(Console.ReadLine());

if(s == 1)
{
    Console.WriteLine("Понедельник!");
}
else if(s == 2)
{
    Console.WriteLine("Вторник!");
}
else if(s == 3)
{
    Console.WriteLine("Среда!");
}
else if(s == 4)
{
    Console.WriteLine("Четверг!");
}
else if(s == 5)
{
    Console.WriteLine("Пятница!");
}
else if(s == 6)
{
    Console.WriteLine("Суббота!");
}
else if(s == 7)
{
    Console.WriteLine("Воскресенье!");
}
else
{
    Console.WriteLine("Error");
}