/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Введите количества строк:");
int lines1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количества столбцов:");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] numbers1 = new int[lines1,columns1];
ArrayRandomNumbers(numbers1);

int[,] numbers2 = new int[columns1,lines1];
int[,] product = new int[lines1,lines1];
ArrayRandomNumbers(numbers2);

Console.WriteLine();
Console.WriteLine("Массив 1");
PrintArray(numbers1);


Console.WriteLine();
Console.WriteLine("Массив 2");
PrintArray(numbers2);

for (int i = 0; i < numbers1.GetLength(0); i++)
{
    for (int j = 0; j < numbers2.GetLength(1); j++)
    {
        for (int k = 0; k < numbers2.GetLength(0); k++)
        {
            product[i,j] += numbers1[i,k] * numbers2[k,j];
        }
    }
}

Console.WriteLine();
Console.WriteLine("Массив перемноженный");
PrintArray(product);

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}