System.Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
    number = -number;
for (int i = -number; i < number; i++)
{
    System.Console.Write($"{i}, ");
}
System.Console.Write(number);