
/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int[] GetArray()
{   System.Console.WriteLine("Задайте размер массива: ");
    int arrayL = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[arrayL];
    for (int i=0; i<arrayL; i++)
    {   Console.Write($"{i} элемент из {arrayL - 1} ");
        array [i] = Convert.ToInt32(Console.ReadLine());
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

int Count(int[] array)
{
    int result  = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result += 1;
        }
    }
    return result;
}
int[] array = GetArray();
PrintArray(array);
Console.Write(Count(array));