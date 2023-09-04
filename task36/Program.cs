// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
System.Console.WriteLine("Задайте размер массива и его числовые пределы: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i<arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.Write("]");
}
int SummaElements(int [] arrayToSum)
{   int summa = 0; 
    for (int i = 0; i < arrayToSum.Length; i++)
    {
        if (i % 2 != 0)
        {
            summa += arrayToSum[i];
        }
    }
    return summa;
}
int[] array = GetRandomArray(arrayL, min, max);
PrintArray(array);
Console.WriteLine("");
Console.Write($"Сумма элементов, стоящих на нечётных позициях равна {SummaElements(array)}");