/* 69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

int result = ProdNumber(5,2);

int ProdNumber (int n, int m)
{   
    if (m==1)
    return n;
    else
    return n*ProdNumber(n,m-1);
}
System.Console.WriteLine(result);