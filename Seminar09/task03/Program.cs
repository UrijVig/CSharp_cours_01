int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int num)
{
    if (num == 0) return 0;
    return num %10 + SumNumbers(num / 10);
    
}

int number = ReadInt("Введите число: ");
System.Console.WriteLine(SumNumbers(number));
