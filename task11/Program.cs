// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int numberOne = number / 100;
int numberThree = number % 10;
int result = numberOne*10 + numberThree;
Console.WriteLine(result);