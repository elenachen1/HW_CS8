/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int sum = 0;
int max = 0;
int strnum = 0;

Console.WriteLine("Введите количества строк:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количества столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines,columns];
ArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив");
PrintArray(numbers);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for( int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i,j];
    }
   
    if (sum >= max)
    {
        max = sum;
        strnum = i;
    }
    sum = 0;
}
Console.WriteLine($"Строка с максимальной суммой: {strnum}");

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