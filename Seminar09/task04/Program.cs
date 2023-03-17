int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int MultNumbers(int numA,int numB)
{
    if (numB == 0) return 1;
    return numA * MultNumbers(numA,numB-1);
    
}

int number1 = ReadInt("Введите число: ");
int number2 = ReadInt("Введите число: ");
System.Console.WriteLine(MultNumbers(number1,number2));