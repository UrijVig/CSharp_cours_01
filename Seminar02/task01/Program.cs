// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random random = new Random();
int randNumber = random.Next(10, 100);

System.Console.WriteLine($"Случайное число:  {randNumber}");

int leftNumber = randNumber / 10;
int rightNumber = randNumber % 10;

if (leftNumber < rightNumber)
    System.Console.WriteLine($"{leftNumber} < {rightNumber}");
else if (leftNumber > rightNumber)
    System.Console.WriteLine($"{leftNumber} > {rightNumber}");
else
    System.Console.WriteLine($"{leftNumber} = {rightNumber}");