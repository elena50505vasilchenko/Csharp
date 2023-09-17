// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ввдите число N: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int [a];
void Fibonacci(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i+2];
        Console.WriteLine(array[i]);
    }
    Console.Write("]");
}

Fibonacci(array);
