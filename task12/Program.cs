// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 % number2;
if (result == 0)
{
    Console.WriteLine("Второе число кратное первому");
}
else
{
    Console.WriteLine($"Остаток от деления {result}");
}
