Console.Write("Введите длины стороны: ");
int[] FillUserArray()
{
    int [] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
bool TriangleExistance(int[] array)
{
    
    
    
        if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[0] + array[1])
        {
            return true;
        }
        else
        return false;
        
    

}
int [] userArray = FillUserArray();
bool result = TriangleExistance(userArray);
Console.WriteLine(result);