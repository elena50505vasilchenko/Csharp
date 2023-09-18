﻿// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Write("Введите кол-во строк треугольника Паскаля: ");
int rows = Convert.ToInt32(Console.ReadLine());

int[][] PascalTriangle(int qtyRows)
{
    // Создаём вертикальный массив
    int[][] triangleArray = new int[qtyRows][];

    for (int i = 0; i < qtyRows; i++)
    {
        // создаем горизонтальные массивы в каждом элементе вертикального
        triangleArray[i] = new int[i + 1];

        // заполняем бёдра единицами 
        triangleArray[i][0] = 1;
        triangleArray[i][i] = 1;

        // теперь заполняем остальные значения
        for (int j = 1; j < i; j++)
        {
            triangleArray[i][j] = triangleArray[i - 1][j - 1] + triangleArray[i - 1][j];
        }
    }

    return triangleArray;
}

void PrintPascalTriangle(int[][] arrayForPrint, int qtyRows)
{
    // высчитаем длинну максимального значения
    int maxLength = arrayForPrint[qtyRows - 1][qtyRows / 2].ToString().Length;

    for (int i = 0; i < rows; i++)
    {
        // посчитаем кол-во пробелов, которые надо поставить перед первым элементом в строке
        int spaces = (qtyRows - i - 1) * (maxLength + 1) / 2;
        Console.Write(new string(' ', spaces));

        for (int j = 0; j <= i; j++)
        {
            Console.Write(Convert.ToString(arrayForPrint[i][j]).PadLeft(maxLength + 1));
        }

        Console.WriteLine();
    }
}

int[][] trianglePascal = PascalTriangle(rows);
PrintPascalTriangle(trianglePascal, rows);