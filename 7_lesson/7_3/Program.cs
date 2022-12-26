// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

string FindElem(int[,] arr, int findNum)
{
for (int i = 0; i < arr.GetLength(0); i++)
for (int j = 0; j < arr.GetLength(1); j++)
if (arr[i, j] == findNum)
return $"Искомый элемент {findNum} находится на позиции [{i + 1}, {j + 1}]";
return $"Искомый элемент {findNum} не найден";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(FindElem(arr_1, int.Parse(Console.ReadLine())));