System.Console.Write("Введите число: ");
string? number = Console.ReadLine();
if (number!.Length < 3)
    System.Console.WriteLine("Число не содержит третьец цыфры!");
else 
{
    System.Console.WriteLine($"Третья цыфра числа - {number[2]}");
}