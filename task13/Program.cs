// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());


while (number > 999)
{
    number /= 10;
}
int result = number % 100 % 10;
if (number > 1000)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(result);
}