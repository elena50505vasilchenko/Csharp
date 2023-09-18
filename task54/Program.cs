/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


int[,] GetRandom2DArray(int rowNumber, int min, int max)
{
    int[,] result = new int[rowNumber, rowNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < rowNumber; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}] \t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                int maxElement = j;
                int temp = 0;
                if (array[i,k] > array[i,maxElement])
                {
                    maxElement = k;
                    temp = array[i,j];
                    array[i,j] = array[i,maxElement];
                    array[i,maxElement] = temp;
                }
            }
        }
    }
    return array;
}

int[,] userArray = GetRandom2DArray(5,0,10);
Print2DArray(userArray);
Print2DArray(SortedArray(userArray));