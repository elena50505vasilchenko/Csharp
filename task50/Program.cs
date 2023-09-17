/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
 */



int[,] Fill2DArray()
{
    Console.Write("Введите кол-во столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    Console.Write("Введите минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }

    return array;
}
void Get2DArray(int[,] arrayForPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayForPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
     System.Console.WriteLine();
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayForPrint[i,j] +"\t");
        }
        System.Console.WriteLine();
    }
}
void PrintElementFrom2DArray(int[,] array)
{
    Console.WriteLine("Введите позицию элемента:");
    Console.Write("Строка: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец: ");
    int col = Convert.ToInt32(Console.ReadLine());

    if (line < array.GetLength(0) && col < array.GetLength(1)) Console.WriteLine(array[line, col]);
    else Console.WriteLine("нет такого элемента");
}
void PrintFindNumberFrom2DArray(int[,] array2DForFindNumber)
{
    Console.Write("Введите искомое число: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    bool checkNumber = true;

    for (int i = 0; i < array2DForFindNumber.GetLength(0); i++)
    {
        for (int j = 0; j < array2DForFindNumber.GetLength(1); j++)
        {
            if (array2DForFindNumber[i, j] == userNumber)
            {
                Console.WriteLine($"Число {userNumber} находится на {i} строке, {j} столбце");
                checkNumber = false;                
            }
        }
    }

    if (checkNumber) Console.WriteLine($"Числа {userNumber} нет в массиве");
}

int[,] userArray = Fill2DArray();
Print2DArray(userArray);
PrintElementFrom2DArray(userArray);
PrintFindNumberFrom2DArray(userArray);