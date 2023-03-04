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

void Flip(int[] array)
{

    int number;
    for (int i = 0; i < array.Length / 2; i++)
    {
        number = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = number;
    }
}

var myArray = AddArray(8, -6, 7);
WriteArray(myArray);
Flip(myArray);
WriteArray(myArray);
