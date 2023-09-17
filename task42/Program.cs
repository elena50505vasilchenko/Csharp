
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ввдите число N: ");
int a = Convert.ToInt32(Console.ReadLine());
string Delenie(int a)
{
    string result = String.Empty;
    int temp = 0;
    for (int i = a; i > 0; i/=2)
    {
        temp = i % 2;
        result += temp;
    }
    return result;
}
string b = Delenie(a);
Console.WriteLine(b);