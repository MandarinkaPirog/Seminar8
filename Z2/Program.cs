//Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу,
// которая будет находить произведение двух матриц.

Console.WriteLine("Первая матрица:");
int[,] matrix1 = new int[2, 2];
for (int i1 = 0; i1 < 2; i1++)
{
    for (int j1 = 0; j1 < 2; j1++)
    {
        matrix1[i1, j1] = new Random().Next(1, 10);
        Console.Write(matrix1[i1, j1] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Вторая матрица:");
int[,] matrix2 = new int[2, 2];
for (int i2 = 0; i2 < 2; i2++)
{
    for (int j2 = 0; j2 < 2; j2++)
    {
        matrix2[i2, j2] = new Random().Next(1, 10);
        Console.Write(matrix2[i2, j2] + " ");
    }
    Console.WriteLine();
}
int [,] NewMatrix(int[,] matrix1, int [,] matrix2)
{
    int [,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int sum=0;
    for (int i= 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            sum=0;
            for (int m = 0; m < matrix1.GetLength(1); m++)
            {
                sum += matrix1[i,m]* matrix2[m,j];
            }
            result[i,j]=sum;
        }
    }
    return result;
}
Console.Write ("Произведение двух матриц : ");
Array(NewMatrix(matrix1,matrix2));
void Array (int[,] array1)
{
    int [] buf = new int[array1.GetLength(1)];
    for (int i=0;i <array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++) 
        {
            buf[j]= array1[i,j];
        }
        System.Console.WriteLine(string.Join(",", buf));
    }
}