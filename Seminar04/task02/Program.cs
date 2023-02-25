// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CountInt(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;

    }
    return count;
}

// string ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Console.ReadLine();
// }

// int CountInt(string number)
// {
//     return number.Length;
// }


int number = ReadInt("Введите число A: ");
System.Console.WriteLine($"количество цифр в числе {number} = {CountInt(number)}");

number = ReadInt("Введите число B: ");
System.Console.WriteLine($"количество цифр в числе {number} = {CountInt(number)}");

number = ReadInt("Введите число C: ");
System.Console.WriteLine($"количество цифр в числе {number} = {CountInt(number)}");