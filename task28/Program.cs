using Internal;
using System;
// See https://aka.ms/new-console-template for more information
int[] GetRandomArray() 
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
int[] userArray = GetRandomArray();

void PrintArray(int[] arrayToPrit)
{
    for (int i = 0; i < arrayToPrit.Length; i++)
    {
        Console.WriteLine();
    }
}