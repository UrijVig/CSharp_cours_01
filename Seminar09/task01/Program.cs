int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num)
{
    if (num < 1) return;
    WriteNumbers(num - 1);
    System.Console.Write(num + " ");
}

int number = ReadInt("Введите число: ");
WriteNumbers(number);