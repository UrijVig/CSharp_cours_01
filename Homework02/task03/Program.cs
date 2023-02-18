// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write($"Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 7 && number >= 1)
{
    if (number == 6 || number == 7)
        System.Console.WriteLine($"День выходной");
    else
        System.Console.WriteLine($"День не выходной");
}
else
    System.Console.WriteLine($"День не подходит под условия");