// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

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
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    // System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int lenght = ReadInt("Введите длинну массива: ");
int minValue = ReadInt("Введите минимальное значение диапозона: ");
int maxValue = ReadInt("Введите максимальное значение диапозона: ");

WriteArray(AddArray(lenght,minValue,maxValue));