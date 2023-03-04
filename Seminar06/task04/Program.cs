int[] AddArray(int number)
{
    int[] array = new int[number];
    array[0]=0;
    array[1]=1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i]= array[i-1] + array[i-2];
    }
    return array;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int number = ReadInt("Введите количество чисел фибоначи: ");
int[] fibonachi = AddArray(number);
WriteArray(fibonachi);