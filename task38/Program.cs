// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
System.Console.WriteLine("Задайте размер массива и его числовые пределы: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());


double[] GetRandomArray(int arrayLength1, double start, double end)
{
    double[] array = new double[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = Math.Round((new Random().NextDouble() * (max - min) + min), 2);
    }
    return array;
}
void PrintArray(double[] arrayToPrint)
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

void DifferenceMinMax(double[] arrayToDifference)
{
    double min = arrayToDifference[0];
    double max = arrayToDifference[0];
        for (int i = 1; i < arrayToDifference.Length; i++)
        {
            if (min > arrayToDifference[i])
                min = arrayToDifference[i];
        }
        Console.WriteLine($"Минимальное число равно {min}");
 
    
        for (int i = 1; i < arrayToDifference.Length; i++)
        {
            if (arrayToDifference[i] > max)
                max = arrayToDifference[i];
        }
        Console.WriteLine($"Максимальное число равно {max}");
        Console.WriteLine($"Разница между числами равна {Math.Round((max - min),2)}");
}


double[] array = GetRandomArray(arrayL, min, max);
PrintArray(array);
Console.WriteLine("");
DifferenceMinMax(array);
