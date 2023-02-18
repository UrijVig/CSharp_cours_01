// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random random = new Random();
int randNumber = random.Next(100, 1000);

System.Console.WriteLine($"Случайное число:  {randNumber}");

int leftNumber = randNumber / 100;
int rightNumber = randNumber % 10;

randNumber = leftNumber * 10 + rightNumber;

System.Console.WriteLine($"{randNumber}");