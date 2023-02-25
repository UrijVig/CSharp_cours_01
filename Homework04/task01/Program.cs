// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Degree(int A, int B)
{
    int deg = 1;
    for (int i = 0; i < B; i++)
    {
        deg *= A;
    }
    return deg;
}

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");

System.Console.WriteLine($"Число {numberA} в степени {numberB} = {Degree(numberA,numberB)}");

numberA = ReadInt("Введите число A: ");
numberB = ReadInt("Введите число B: ");

System.Console.WriteLine($"Число {numberA} в степени {numberB} = {Degree(numberA,numberB)}");