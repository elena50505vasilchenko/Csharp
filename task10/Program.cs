// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10 % 10;
Console.WriteLine(result);