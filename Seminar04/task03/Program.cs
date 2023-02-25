// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Multipli(int number)
{
    int multi = 1;
    for (int i = 2; i <= number; i++)
    {
        multi *= i;
    }
    return multi;
}

int number = ReadInt("Введите число А: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Multipli(number)}");

number = ReadInt("Введите число B: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Multipli(number)}");

number = ReadInt("Введите число C: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Multipli(number)}");