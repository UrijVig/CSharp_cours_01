// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int number = ReadInt("Введите число А: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");

number = ReadInt("Введите число B: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");

number = ReadInt("Введите число C: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");