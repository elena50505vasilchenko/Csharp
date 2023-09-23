/* 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

void NuturalNum(int n, int start = 1)
{
    if (start <= n)
    {
        System.Console.Write(start+", ");
        NuturalNum(n, start + 1);
    }
}
NuturalNum(5);