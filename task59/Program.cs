﻿/* 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 25 9 2 38 4 2 45 2 6 7Наименьший элемент - 1, на выходе получим 
следующий массив:9 4 22 2 63 4 7
*/


Console.Clear();
/*
System.Console.WriteLine("Введи кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи кол-во столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
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

int[] CoordMinValue(int[,] array)
{
    int[] result = new int[2];
    int min = array[0, 0];
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min = array[i, j];
            result[0] = i;
            result[1] = j;
        }
    }
    return result;
}

int[,] DelCross(int[,] array)
{ int[] coords = CoordMinValue(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[coords[0],i] = 0;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, coords[1]] = 0;
    }
    return array;
}

int[,] arr = GetRandom2DArray(rows,columns,minNum,maxNum);
Print2DArray(arr);
System.Console.WriteLine();
int[,] arr2 = DelCross(arr);
Print2DArray(arr2);
*/

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);

Console.WriteLine($"Позиция наименьшего элемента [{String.Join(", ", FindMinPosition(arr))}]");
int[,] newArr = RemoveCross(arr, FindMinPosition(arr));
PrintMatrix(newArr);

// Заполнение массива случайными числами
int[,] FillMatrixRnd(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Позиция минимального элемента
int[] FindMinPosition(int[,] matrix)
{
    int[] position = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                position[0] = i;
                position[1] = j;
            }
        }
    }
    return position;
}

// Удаление строки и столбца по индексам элемента
int[,] RemoveCross(int[,] matrix, int[] pos)
{
    int row = matrix.GetLength(0) - 1;
    int col = matrix.GetLength(1) - 1;
    int[,] result = new int[row, col];
    int iRes = 0, jRes = 0;     // позиции элементов результирующего массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == pos[0])
            continue;   // пропускаем указанную строку
        else
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == pos[1])
                    continue;   // пропускаем указанный столбец
                else
                {
                    result[iRes, jRes] = matrix[i, j];
                    jRes++;
                }
            }
            iRes++;
            jRes = 0;   // сбрасываем индекс столбца результата
        }
    }
    return result;
}