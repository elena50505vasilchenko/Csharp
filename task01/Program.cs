
Console.WriteLine("Введи первое число: ");
int numder1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int numder2 = Convert.ToInt32(Console.ReadLine());
if (numder1 == numder2 * numder2)
{
    Console.WriteLine("Первое число является квадратом второго");
} 
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}