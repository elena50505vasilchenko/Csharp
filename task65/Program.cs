/* 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/

void NuturalNum(int m, int n)
{
    if (m <= n)
    {
        System.Console.Write(m+", ");
        NuturalNum(m+1 , n);
    }
}
NuturalNum(1,7);