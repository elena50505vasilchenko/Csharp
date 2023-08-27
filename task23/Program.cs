// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Ввдите число N: ");
int numder = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (numder < 0)
{
    numder = numder * (-1);
}
for (int i = 1; i <= numder; i++)
{
    result = i * i * i;
    Console.WriteLine(result);
}