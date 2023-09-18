/* 57. Составить частотный словарь элементов двумерного 
массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/


Console.Clear();
//Первый вар не завершен
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

void FindNumber(int[,] array, int find)
{
    int count = 0
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find) count++;
        }
    }
    return count;
}

void [] UniqNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int count = 0;
            int temp = [i, j];
            for (int k = 0; k < length; k++)
            {
                
            }
        }
    }
}

int[,] arr = GetRandom2DArray(rows,columns,minNum,maxNum);
Print2DArray(arr);
System.Console.WriteLine();
Print2DArray(ChangeStringAndColumns(arr));
*/
//Второй вар 


Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillMatrixRnd(m, n);
PrintMatrix(arr);

int[] expandArray = ExpandMatrix(arr);
CollectionSort(expandArray);
// Console.WriteLine($"[{String.Join(", ", expandArray)}]");
RepeatRate(expandArray);


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

// Разворот матрицы в одномерный массив
int[] ExpandMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0) * matrix.GetLength(1);
    int[] array = new int[n];
    n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }
    return array;
}

// Сортировка элементов по возрастанию
void CollectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        if (i != minPosition)
        {
            int tmp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = tmp;
        }
    }
}

// Вывод количества повторений значения элемента массива
void RepeatRate(int[] array)
{
    int save = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == save)
            count++;
        else
        {
            Console.WriteLine($"{save} - {count} шт");
            save = array[i];
            count = 1;
        }
        if (i == array.Length - 1)
            Console.WriteLine($"{save} - {count} шт");
    }
}


//Третий вар 
/*
int CountUniqElementsInArray(int[] arrayForCountUniqElements)
{
    int uniqueCount = 0;
    bool[] counted = new bool[arrayForCountUniqElements.Length];

    for (int i = 0; i < arrayForCountUniqElements.Length; i++)
    {
        if (!counted[i])
        {
            uniqueCount++;

            for (int j = i + 1; j < arrayForCountUniqElements.Length; j++)
            {
                if (arrayForCountUniqElements[i] == arrayForCountUniqElements[j])
                {
                    counted[j] = true;
                }
            }
        }
    }

    return uniqueCount;
}
int[] FillArrayOnlyUniqElements(int[] array)
{
    int[] uniqArray = new int[CountUniqElementsInArray(userArray)];
    int uniqueCount = 0;  // капец сложный момент с uniqueCount 

    for (int i = 0; i < array.Length; i++)
    {
        bool isUnique = true;

        // Проверяем, является ли элемент уникальным в массиве
        for (int j = 0; j < uniqueCount; j++) // чтобы 0 не переносился в конец массива также используем uniqueCount
        {
            if (array[i] == uniqArray[j])
            {
                isUnique = false;
                break;
            }
        }

        // Если элемент уникальный, добавляем его в новый массив
        if (isUnique)
        {
            uniqArray[uniqueCount] = array[i];
            uniqueCount++;
        }
    }

    return uniqArray;
}
void PrintFrequencyVocabulary(int[] arrayForCountNumber, int[] uniqueArray)
{
    for (int i = 0; i < uniqueArray.Length; i++)
    {
        int element = uniqueArray[i];
        int countElement = 0;
        for (int j = 0; j < arrayForCountNumber.Length; j++)
        {
            if (element == arrayForCountNumber[j]) countElement++;
        }

        Console.WriteLine($"{element} встречается {countElement} раз");
    }
}
*/