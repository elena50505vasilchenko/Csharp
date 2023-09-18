/* 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

int[,,] Get3DArray()
{
    Console.WriteLine("Введи кол-во строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи кол-во столбцов массива: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи глубину массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[rows, cols, depth];
    Console.WriteLine("Введи Мин значение элементов массива: ");
    int minNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введи Макс значение элементов массива: ");
    int maxNum = Convert.ToInt32(Console.ReadLine());

    if (maxNum - minNum < rows * cols * depth) Console.WriteLine("массив не может быть заполнен без повторений");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    bool nonRepetitive;
                    int randomNum = 0;
                    do
                    {
                        nonRepetitive = false;
                        randomNum = new Random().Next(minNum, maxNum);
                        foreach (var item in array)
                        {
                            if (item == randomNum) nonRepetitive = true;
                        }
                    } while (nonRepetitive);
                    array[i, j, k] = randomNum;
                }
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i}, {j}, {k}] = {arrayToPrint[i, j, k]}");
            }
        }
    }
}
int[,,] array = Get3DArray();
Print3DArray(array);