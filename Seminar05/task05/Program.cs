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

int[] Find(int[] array)
{

    int[] multiArray = new int[(array.Length + 1) / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        multiArray[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 == 1)
        multiArray[^1] = array[array.Length / 2];
    return multiArray;

}

var myArray = AddArray(11, 0, 7);
WriteArray(myArray);

var newArray = Find(myArray);
WriteArray(newArray);