System.Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 || number < 100)
    System.Console.WriteLine($"Введённое число не соответствует условию задачи");
else
    System.Console.WriteLine(number % 10);