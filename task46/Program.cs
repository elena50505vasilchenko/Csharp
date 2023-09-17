
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[,] GetRandom2DArray(int rowNumber, int columnNumber, int deviation)
 {
    int[,] result = new int[rowNumber,columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i,j] = new Random().Next(- deviation, deviation);
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
            Console.Write($"{arrayToPrint[i,j]}\t");
        }
    Console.WriteLine();
    }
 }

 Print2DArray(GetRandom2DArray(5,5,10));