// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int numL,int numR)
{
    if (numL > numR) return 0;
    return numR + SumNumbers(numL, numR - 1);
    
}

int number1 = ReadInt("Введите число: ");
int number2 = ReadInt("Введите число: ");
if (number1<number2) System.Console.WriteLine(SumNumbers(number1, number2));
else System.Console.WriteLine(SumNumbers(number2, number1));