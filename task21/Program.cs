
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты: ");
int coordinatesOne = Convert.ToInt32(Console.ReadLine());
int coordinatesTwo = Convert.ToInt32(Console.ReadLine());
int coordinatesTree = Convert.ToInt32(Console.ReadLine());

int coordinatesFor = Convert.ToInt32(Console.ReadLine());
int coordinatesFive = Convert.ToInt32(Console.ReadLine());
int coordinatesSix = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((coordinatesFor - coordinatesOne) * (coordinatesFor - coordinatesOne) + (coordinatesFive - coordinatesTwo) * (coordinatesFive - coordinatesTwo) + (coordinatesSix - coordinatesTree) * (coordinatesSix - coordinatesTree));
double distance  = Math.Round(result, 2);
Console.Write(distance);
