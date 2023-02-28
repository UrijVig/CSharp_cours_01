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

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Find(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            System.Console.WriteLine("Искомое число найдено");
            return;
        }
    }
    System.Console.WriteLine("Искомое число не найдено");
}

var myArray = AddArray(8, -6, 7);
WriteArray(myArray);
int number = ReadInt("Введите искомое число: ");
Find(myArray, number);
