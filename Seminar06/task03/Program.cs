int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Counter(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 2;
        count++;
    }
    return count;
}

int[] AddArray(int number)
{
    int[] array = new int[Counter(number)];
    for (int i = 0; i < array.Length; i++)
    {
        array[array.Length - i - 1] = number % 2;
        number /= 2;
    }
    return array;
}

// void GetBinaryView(int number)
// {
//     if (number == 0) return;
//     GetBinaryView(number / 2);
//     System.Console.WriteLine(number % 2);
// }


void WriteArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join("", array) + "]");
}

int numberTeen = ReadInt("Введите десятичное число: ");
System.Console.Write("Ваше число в двоичной системе: ");
WriteArray(AddArray(numberTeen));