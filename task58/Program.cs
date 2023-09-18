﻿/* 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

int[,] Fill2DArrayA()
{
    Console.Write("Введите кол-во столбцов массива А: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк массива А: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    Console.Write("Введите минимальное значение массива А: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение массива А: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return array;
}
int[,] Fill2DArrayB(int rows)
{
    Console.Write("Введите кол-во столбцов массива B: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    Console.Write("Введите минимальное значение массива B: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение массива B: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }

    return array;
}
void Print2DArray(int[,] arrayForPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayForPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write(arrayForPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] ProductArrays(int[,] arrayForProductA, int[,] arrayForProductB)
{
    int rowsA = arrayForProductA.GetLength(0);
    int colsA = arrayForProductA.GetLength(1);
    int rowsB = arrayForProductB.GetLength(0);
    int colsB = arrayForProductB.GetLength(1);
    int[,] result = new int[rowsA, colsB];
    int productElements = 1;

    for (int i = 0; i < rowsA; i++)
    {
        for (int m = 0; m < colsB; m++)
        {
            for (int j = 0; j < colsA; j++)
            {
                productElements = arrayForProductA[i, j] * arrayForProductB[j, m];
                result[i, m] += productElements;
            
            }
        }
    }

    return result;
}


int[,] arrayA = Fill2DArrayA();
int rows = arrayA.GetLength(1);
int[,] arrayB = Fill2DArrayB(rows);
int[,] productArrays = ProductArrays(arrayA, arrayB);

Print2DArray(arrayA);
Console.WriteLine();
Print2DArray(arrayB);
Console.WriteLine();
Print2DArray(productArrays);