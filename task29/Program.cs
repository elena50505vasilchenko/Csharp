//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Задайте диапазон чисел: ");
int start = Convert.ToInt32(Console.ReadLine());
int finish = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int start, int finish) 
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, finish);
    }
    return array;
}

void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i < arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.Write("]");
}

PrintArray(GetRandomArray(start, finish));