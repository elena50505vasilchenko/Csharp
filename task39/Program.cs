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

int[] TurnAray(int[] arrayForTurn)
{
    int temp = 0;
    for (int i = 0; i < arrayForTurn.Length/2; i++)
    {
        temp = arrayForTurn[i];
        arrayForTurn[i] = arrayForTurn[arrayForTurn.Length - 1 - i];
        arrayForTurn[arrayForTurn.Length - 1 - i] = temp;
    } 
    return arrayForTurn;
}
int[] turnArray = GetRandomArray(arrayL, min, max);
PrintArray(turnArray);
Console.WriteLine("");
PrintArray(TurnAray(turnArray));
