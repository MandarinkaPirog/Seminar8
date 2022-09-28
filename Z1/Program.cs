//Задача 1: Задайте двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.

int[,] array = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int MinSum (int [,] array)
{
int Index =0;
int Sum =0;
int Min=0;
for (int i = 0; i < array.GetLength(0); i++)
{
    Sum=0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Sum += array[i,j];
    }
    if (i == 0)
    {
        Min = Sum;
    }
    else
    {
        if (Min> Sum)
        {
            Min= Sum;
            Index = i;
        }
    }
}
return Index;
}
Console.Write ("Индекс строки с наименьшей суммой элементов: ");
Console.Write(MinSum(array));

