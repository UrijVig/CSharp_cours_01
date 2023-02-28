// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] AddArray(int lenght)
{
    double[] array = new double[lenght];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble();
    }
    return array;
}

void WriteArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double DifferenceMaxMin (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        if (array[i]<min)
        {
            max = array[i];
        }
    }    
    return max - min;
    
}

var myArray = AddArray(8);
WriteArray(myArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DifferenceMaxMin(myArray)}");