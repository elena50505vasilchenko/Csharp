// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int palindrome = 0;
for (int i = number; i > 0; i /= 10)
{
    palindrome = i % 10 + palindrome * 10;
}
if (palindrome == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}