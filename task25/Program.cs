// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите два числа: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());

int GetAB(int One, int Two)
{   int result = 1;
    
    while (Two > 0)
    {
        result *= One;
        Two -= 1;
    }
    
    if (One < 0)
    {
         result = result * -1;
    }
    return result;
} 
Console.WriteLine($"Число {numberOne} в степени {numberTwo} равно {GetAB(numberOne, numberTwo)}");