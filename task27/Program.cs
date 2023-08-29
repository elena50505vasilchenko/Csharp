//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum(int userNumber)
{
int sum = 0;
while (userNumber > 0)
{
    sum += userNumber % 10;
    userNumber /= 10;
}
return sum;
}
Console.WriteLine(GetSum(number));