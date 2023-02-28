int[] AddArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);
    }
    return array;
}

void WriteArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Find(int[] array, int numberLeft, int numberRight)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= numberRight && array[i] >= numberLeft)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество элементов в диапазоне от 10 до 99: {count}");
}

var myArray = AddArray(123, -6, 123);
WriteArray(myArray);

Find(myArray, 10, 99);
