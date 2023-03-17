int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int num1, int num2)
{
    if (num2 < num1) return;
    WriteNumbers(num1, num2 - 1);
    System.Console.Write(num2 + " ");
}

int number1 = ReadInt("Введите число: ");
int number2 = ReadInt("Введите число: ");
if (number1<number2) WriteNumbers(number1, number2);
else WriteNumbers(number2, number1);
