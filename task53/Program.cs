/* 53. Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
*/
Console.Clear();

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

int[,] ResultArrey(int[,] array)
{
    int cols = array.GetLength(1);
    int rows = array.GetLength(0);
    int temp = 0;

    for (int i = 0; i < cols; i++)
    {
        temp = array[0, i];
        array[0, i] = array[rows - 1, i];
        array[rows - 1, i] = temp;

    }
    return array;
}

int[,] arr = GetRandom2DArray(rows,columns,minNum,maxNum);
Print2DArray(arr);
System.Console.WriteLine();
int[,] arr2 = ResultArrey(arr);
Print2DArray(arr2);