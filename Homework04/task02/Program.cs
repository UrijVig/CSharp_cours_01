// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        count += number % 10;
        number /= 10;
    }
    return count;
}

int number = ReadInt("Введите число A: ");
System.Console.WriteLine($"Сумма цифр в числе {number} = {SumNumber(number)}");

number = ReadInt("Введите число B: ");
System.Console.WriteLine($"Сумма цифр в числе {number} = {SumNumber(number)}");

number = ReadInt("Введите число C: ");
System.Console.WriteLine($"Сумма цифр в числе {number} = {SumNumber(number)}");