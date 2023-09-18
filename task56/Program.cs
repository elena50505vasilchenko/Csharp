/* 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

System.Console.WriteLine("Введи кол-во строк и столбцов массива: ");
int rowscols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи Мин значение элементов массива: ");
int minNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи Макс значение элементов массива: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[,] GetRandom2DArray(int rowNumber, int colNumber, int min, int max)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(min, max); ;
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] RowMinSums(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRows[i] += array[i, j];
        }
    }
    return sumRows;
}

void PrintArray(int[] arrayForPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i]);
        if (i < arrayForPrint.Length - 1) System.Console.Write(", ");
    }
    Console.WriteLine("]");
}

void PrintMinElement(int[] array)
{
    int minSum = array[0];
    int rowFrom2DArray = 0; // Номер элементна будет соответствовать строке в двумерном массиве.

    for (int i = 1; i < array.Length; i++)
    {
        if (minSum > array[i])
        {
            minSum = array[i];
            rowFrom2DArray = i;
        }
    }

    Console.WriteLine($"Наименьшая сумма элементов будет в строке №{rowFrom2DArray} и она равна {minSum}");
}

int[,] arr = GetRandom2DArray(rowscols, rowscols, minNum, maxNum);
Console.ForegroundColor = ConsoleColor.Red;
Print2DArray(arr);
System.Console.WriteLine();
int[] arr2 = RowMinSums(arr);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray(arr2);
Console.ForegroundColor = ConsoleColor.Blue;
PrintMinElement(arr2);
Console.ForegroundColor = ConsoleColor.White;