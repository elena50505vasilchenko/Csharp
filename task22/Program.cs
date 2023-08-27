

Console.WriteLine("Ввдите число N: ");
int numder = Convert.ToInt32(Console.ReadLine());
double result = 0;
if (numder < 0)
{
    numder = numder * (-1);
}
for (int i = 1; i <= numder; i++)
{
    result = Math.Pow(i, 2);
    Console.WriteLine(result);
}